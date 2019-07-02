using GoogleTranslateFreeApi;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTranslateResxFiles
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cultureFrom = "en";
            var folder =
                new DirectoryInfo(@"D:\workspace\JPProject.IdentityServer4.AdminUI\src\Frontend\Jp.UI.SSO\Resources");
            var culturesTo = "es;fr;ru;nl";

            foreach (var cultureTo in culturesTo.Split(";"))
            {
                foreach (var resxFile in folder.GetFiles("*.resx", SearchOption.AllDirectories))
                {
                    if (resxFile.Name.Contains(cultureFrom))
                        try
                        {
                            await Translate(resxFile, cultureFrom, cultureTo);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                }
            }
        }

        private static async Task Translate(FileInfo resxFile, string from, string to)
        {
            var content = root.Load(resxFile);
            var destination = root.Load(resxFile);

            var novoArquivo = Path.Combine(resxFile.Directory.FullName,
                Path.GetFileNameWithoutExtension(resxFile.Name).Replace(from, to) + Path.GetExtension(resxFile.Name));

            if (File.Exists(novoArquivo))
                return;

            var translator = new GoogleTranslator();

            var languageFrom = GoogleTranslator.GetLanguageByISO(from.ToLower());
            var languageTo = GoogleTranslator.GetLanguageByISO(to.ToLower());

            foreach (var rootData in content.data)
            {
                var result = await translator.TranslateLiteAsync(rootData.value, languageFrom, languageTo);
                destination.data.First(f => f.name == rootData.name).value = result.MergedTranslation;
                Console.WriteLine($"{rootData.name} - {rootData.value} -> {result.MergedTranslation}");
            }
            destination.SerializeTo(novoArquivo);
        }
    }
}

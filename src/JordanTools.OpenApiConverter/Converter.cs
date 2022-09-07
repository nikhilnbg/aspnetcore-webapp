using System.Text;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

namespace JordanTools.OpenApiConverter
{
    public class Converter : IConverter
    {
        /// <summary>
        /// <see cref="IConverter.ConvertAsync(Stream, OpenApiSpecVersion, OpenApiFormat)"/>
        /// </summary>
        public async Task<string> ConvertAsync(Stream stream, OpenApiSpecVersion specVersion, OpenApiFormat specFormat)
        {
            //// Read V3 as YAML
            //byte[] bytes = new byte[stream.Length];
            //stream.Position = 0;
            //stream.Read(bytes, 0, (int)stream.Length);
            //string data = Encoding.ASCII.GetString(bytes); // this is your string

            var sr = new OpenApiStreamReader();
            stream.Position = 0;
            var openApiDocument = await sr.ReadAsync(stream);

            // Write V2 as JSON
            var outputString = openApiDocument.OpenApiDocument.Serialize(specVersion, specFormat);

            return outputString;
        }
    }
}
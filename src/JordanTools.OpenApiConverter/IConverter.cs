using Microsoft.OpenApi;

namespace JordanTools.OpenApiConverter
{
    public interface IConverter
    {
        /// <summary>
        /// Converts an OpenAPI spec (represented as a <see cref="Stream"/>) to the specified version and format.
        /// </summary>
        /// <param name="stream">The OpenAPI file.</param>
        /// <param name="specVersion">The version of OpenAPI spec to convert to.</param>
        /// <param name="specFormat">The file format.</param>
        /// <returns>The OpenAPI spec in the desired format.</returns>
        Task<string> ConvertAsync(Stream stream, OpenApiSpecVersion specVersion, OpenApiFormat specFormat);
    }
}
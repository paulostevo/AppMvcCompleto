using Microsoft.AspNetCore.Mvc.Razor;
using System;

namespace DevIO.App.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDocumento(this RazorPage page, int tipoPessoa, string documento)
        {
            if (!ulong.TryParse(documento, out ulong documentoNumerico))
            {
                // se a string não pode ser convertida para um valor numérico, retorna a própria string sem formatação
                return documento;
            }

            return tipoPessoa == 1 ? documentoNumerico.ToString(@"000\.000\.000\-00") : documentoNumerico.ToString(@"00\.000\.000\/0000\-00");
        }

    }
}

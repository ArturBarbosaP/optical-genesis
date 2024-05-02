using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

namespace Ótica.PDF
{
    class EventosDePagina : PdfPageEventHelper
    {
        private BaseFont fonteBaseRodape { get; set; }
        private iTextSharp.text.Font fonteRodape { get; set; }
        private int totalPaginas { get; set; }

        public EventosDePagina(int numTotalPaginas)
        {
            fonteBaseRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fonteRodape = new iTextSharp.text.Font(fonteBaseRodape, 8f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            totalPaginas = numTotalPaginas;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            AdicionarMomentoGeracao(writer, document);
            AdicionarNumerosPagina(writer, document);
        }

        private void AdicionarMomentoGeracao(PdfWriter writer, Document document)
        {
            string momentoGeracao = "Gerado em " + DateTime.Now.ToShortDateString() + " às " + DateTime.Now.ToShortTimeString();
            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(momentoGeracao);
            writer.DirectContent.EndText();
        }

        private void AdicionarNumerosPagina(PdfWriter writer, Document document)
        {
            int paginaAtual = writer.PageNumber;
            string textoPagina = "Página " + paginaAtual + " de " + totalPaginas;
            float larguraTexto = fonteBaseRodape.GetWidthPoint(textoPagina, fonteRodape.Size);
            Rectangle tamanhoPagina = document.PageSize;
            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            writer.DirectContent.SetTextMatrix(tamanhoPagina.Width - document.RightMargin - larguraTexto, document.BottomMargin * 0.75f);
            writer.DirectContent.ShowText(textoPagina);
            writer.DirectContent.EndText();
        }
    }
}
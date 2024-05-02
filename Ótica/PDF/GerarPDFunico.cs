using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Ótica.PDF
{
    class GerarPDFunico
    {
        public void GerarRelatorioPDF(string caminhoPdf, string textoTitulo, string nomeArquivo, DataTable dataPDF, float[] larguraColunas, string descricao)
        {
            int totalPaginas = 1;
            float pxPorMm = 72 / 25.2F;
            Document pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm, 15 * pxPorMm, 20 * pxPorMm);
            string caminhoArquivo = caminhoPdf + nomeArquivo + " " + DateTime.Now.ToString("dd.MM.yyyy.HH.mm") + ".pdf";
            FileStream arquvio = new FileStream(caminhoArquivo, FileMode.Create);
            PdfWriter writer = PdfWriter.GetInstance(pdf, arquvio);
            writer.PageEvent = new EventosDePagina(totalPaginas);
            pdf.Open();

            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            iTextSharp.text.Font fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            if (textoTitulo.Length > 23)
            {
                fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32 - (textoTitulo.Length - 23) - 1, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            }

            Paragraph titulo = new Paragraph(textoTitulo + "\n\n", fonteParagrafo);
            titulo.Alignment = Element.ALIGN_LEFT;
            titulo.SpacingAfter = 4 + ((textoTitulo.Length - 23) * 2);

            pdf.Add(titulo);

            var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"IMG\logo.png");

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoImagem);
            float razaoAlturaLargura = logo.Width / logo.Height;
            float aluraLogo = 170;
            float larguraLogo = aluraLogo * razaoAlturaLargura;
            logo.ScaleToFit(larguraLogo, aluraLogo);
            float margemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
            float margemTopo = pdf.PageSize.Height - pdf.TopMargin - 110;
            logo.SetAbsolutePosition(margemEsquerda, margemTopo);
            writer.DirectContent.AddImage(logo, false);

            PdfPTable tabela = new PdfPTable(dataPDF.Columns.Count);
            tabela.SetWidths(larguraColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            //titulo
            for (int i = 0; i < dataPDF.Columns.Count; i++)
            {
                CriarCelulaTexto(tabela, dataPDF.Columns[i].ToString(), PdfPCell.ALIGN_LEFT, true);
            }

            //celula
            for (int r = 0; r < dataPDF.Rows.Count; r++)
            {
                for (int c = 0; c < dataPDF.Columns.Count; c++)
                {
                    CriarCelulaTexto(tabela, dataPDF.Rows[r][c].ToString());
                }
            }

            pdf.Add(tabela);

            iTextSharp.text.Font fonteDesc = new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            Paragraph textoDesc = new Paragraph("\nDESCRIÇÃO:", fonteDesc);
            pdf.Add(textoDesc);

            iTextSharp.text.Font fonteDescC = new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            Paragraph textoDescC = new Paragraph("\n"+descricao, fonteDescC);
            pdf.Add(textoDescC);

            pdf.Close();
            arquvio.Close();
        }

        private static void CriarCelulaTexto(PdfPTable tabela, string texto, int alinhamentoHorizontal = PdfPCell.ALIGN_LEFT, bool negrito = false, bool italico = false, int tamanhoFonte = 12, int alturaCelula = 25)
        {
            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }
            iTextSharp.text.Font fonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte, estilo, BaseColor.BLACK);
            iTextSharp.text.BaseColor bgColor = iTextSharp.text.BaseColor.WHITE;

            PdfPCell cell = new PdfPCell(new Phrase(texto, fonteCelula));
            cell.HorizontalAlignment = alinhamentoHorizontal;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.Border = 0;
            cell.BorderWidthBottom = 0;
            cell.FixedHeight = alturaCelula;
            cell.PaddingBottom = 6;
            cell.BackgroundColor = bgColor;
            tabela.AddCell(cell);
        }
    }
}
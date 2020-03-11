/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 08/12/2019
 * Heure: 22:39
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Criterium_16_4
{
	/// <summary>
	/// Description of ClassementPdf.
	/// </summary>
	public class ClassementPdf
	{
		string _filename;
		
		// Pour la génération des fichiers PDF
		XPen _pen = new XPen(XColors.Black, 1);
		
		XStringFormat _format = new XStringFormat();
		XStringFormat _formatLeft = new XStringFormat();
		
		XFont _font6 	= new XFont("Times",  6, XFontStyle.Regular);
		XFont _font8 	= new XFont("Times",  8, XFontStyle.Regular);
		XFont _font10   = new XFont("Times", 10, XFontStyle.Regular);
		XFont _font12b  = new XFont("Times", 12, XFontStyle.Bold);
		XFont _font14b  = new XFont("Times", 14, XFontStyle.Bold);
		XFont _font18b  = new XFont("Times", 18, XFontStyle.Bold);
		
		PdfDocument _document = new PdfDocument();
		
		XGraphics _gfx;
		
		PdfPage _page;
		
		public ClassementPdf(string filename)
		{
			this._filename = filename;
			
			// Pour les PDF
			this._format.LineAlignment = XLineAlignment.Center;
			this._format.Alignment = XStringAlignment.Center;
			
			// Create a new PDF document
			this._document.Info.Title = "Classement Critérium Fédéral Poules";
			this._document.Info.Subject = "Classement de 16 joueurs en intégral";
			this._document.Info.Author = "Patrick CHAUTARD";
			
			// One page in Portrait...
			this._page = this._document.AddPage();
			this._page.Size = PdfSharp.PageSize.A3;
			this._page.Orientation = PdfSharp.PageOrientation.Landscape;
			
			this._gfx = XGraphics.FromPdfPage(this._page);
		}
		
		public void KI16()
		{
			string fileName = string.Format("{0}{1}PDF{2}16KI.pdf", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar, Path.DirectorySeparatorChar);
			PdfDocument PDFDoc = PdfReader.Open( fileName, PdfDocumentOpenMode.Import );
			
			_document.AddPage(PDFDoc.Pages[0]);
			
			/*-------------------------------------------------------------------------
			 * 			Ecriture des informations dans le fichier
			 *-------------------------------------------------------------------------
			 */
			

			_document.Save("16KI.pdf");
		}	
	}
}

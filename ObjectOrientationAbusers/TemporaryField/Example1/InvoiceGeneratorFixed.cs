class InvoiceGenerator
{
    public void Process()
    {
        new PDFExporter().ExportPDF("PDF_TEMPLATE_2025");
        new EmailSender().SendEmail("EMAIL_TEMPLATE_2025");
    }
}

class PDFExporter
{
    public void ExportPDF(string template)
    {
        //code to generate pdf using the template
    }
}

class EmailSender
{
    public void SendEmail(string template)
    {
        //use template to send email
    }
}
class InvoiceGenerator
{
    private string emailTemplate; //used only for emailing
    private string pdfTemplate; // used only for pdf

    public void ExportPDF()
    {
        pdfTemplate = "PDF_TEMPLATE_2025";
        //code to generate pdf using the template
    }

    public void SendEmail()
    {
        emailTemplate = "EMAIL_TEMPLATE_2025";
        //code to send email using that template
    }
}
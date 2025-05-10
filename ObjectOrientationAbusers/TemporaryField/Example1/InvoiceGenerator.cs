/*
NOTE:
This file is part of the "Code Smells Workshop" repository
The code below is intentionally written with code smells for eductional purposes.
It is meant to demonstrate bad practices and should not be used in production.
*/

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
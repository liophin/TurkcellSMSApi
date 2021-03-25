using CodecFastSMSService;

public class CodecAPI
{

    private static string pUser = ""; //Api Kullanıcı adı bilgisi
    private static string pPwd = "";  //Api Kullanıcı şifresi bilgisi, 
    private static string sender = "";
    //----------------------------------------------------------------------------------

    public static bool SendSMS(string phone, string messageContent, string msgSpecialId)
    {
        FastApiSoapClient client = new FastApiSoapClient();
        string response = client.SendSms(pUser, pPwd, sender, phone, messageContent, msgSpecialId, false, "", 0, "");
        if (response == "OK") { return true; } else { return false; }
    }
    //--------------------------- Cep telefonu numaralarına kısa mesaj (SMS) gönderebileceğiniz web metodudur. Bir istekte en fazla 100 adet numaraya gönderim yapabilirsiniz

    public static bool SendSmsTckn(string tckno, string messageContent, string msgSpecialId)
    {
        FastApiSoapClient client = new FastApiSoapClient(); //api client oluşturuldu
        string response = client.SendSmsTckn(pUser, pPwd, sender, tckno, messageContent, msgSpecialId, false, "", 0, "");
        if (response == "OK") { return true; } else { return false; }
    }
    //--------------------------- T.C. kimlik numaralarına (TCKN) kısa mesaj (SMS) gönderebileceğiniz web metodudur.Bir istekte en fazla 100 adet numaraya gönderim yapabilirsiniz

    public static bool SendSmsTaxNo(string taxno, string messageContent, string msgSpecialId)
    {
        FastApiSoapClient client = new FastApiSoapClient(); //api client oluşturuldu
        string response = client.SendSmsTaxNo(pUser, pPwd, sender, taxno, messageContent, msgSpecialId, false, "", 0, "");
        if (response == "OK") { return true; } else { return false; }
    }
    //--------------------------- T.C. vergi numaralarına kısa mesaj (SMS) gönderebileceğiniz web metodudur.Bir istekte en fazla 100 adet numaraya gönderim yapabilirsiniz

}

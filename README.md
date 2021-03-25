# TurkcellSMSApi
Using Turkcell Codec Fast SMS Api with c#

Mesajların hızlı bir şekilde gönderimini ve raporlanmasını sağlayan bir rest servistir. Servise ait
metotları ve kullanım bilgilerini aşağıda bulabilirsiniz.

    Metodlar

FastSms web servisinde 3 adet gönderim (SendSms, SendSmsTckn, SendSmsTaxNo), 3 adet sorgulama
(GetStatus, GetSenderInfo, GetCredit) ve 1 adet yardımcı (OptionalParameterBuilder) web metotları
bulunmaktadır. 

Ben bu metodlardan sadece gönderim yapılanları kullandım. 
Siz kodları düzenleyerek işinize yarayan metodları kullanabilirsiniz.

    API Genel Değişkenleri

msgSpecialId: Raporlama için kullanılıyor. ID veya neden sms atıldığı bilgisi gönderebilir.

isOtn : Birden çok numaraya tek bir mesaj içeriği göndermek için kullanılır. 
        Parametre değerleri: 
            True – Birden fazla numaraya mesaj gönderildiğinde “messageContent” parametresinde 
                    tek bir mesaj içeriği olduğunu kabul eder 
                   ve tüm numaralara bu içeriğin gönderilmesini sağlar.
            False – Birden fazla numaraya mesaj gönderildiğinde “messageContent” parametresinde 
                    her numara için ~ karakteri ile ayrılmış 
                    mesaj içerikleri olduğunu kabul eder
                    
headerCode : Servisin “GetSenderInfo” metodu ile veya müşteri hizmetlerinden temin edebileceğiniz 
             numerik bir değerdir. Aynı alfanumeriği birden fazla sanal numara üzerinde veya operatörde 
             kullanıyorsanız bu alfanumerikleri ayırt etmek için kullanılır. 
             Bu parametre isteğe bağlıdır. Boş veya null bir değer girilebilir.
             
responseType : Yanıtın hangi formatta döneceğini belirten parametredir.
             Parametre değerleri:
             0 – Temel (OK veya NOK) olarak değer dönüyor bizim için yeterli
             1 – Basit
             2 – Xml
             3 – Json
             
optionalParameters: Boş veya null bir değer girilebilir. Dökümanda “İSTEĞE BAĞLI PARAMETRE KULLANIMI”
                    bölümünden detaylı bilgi edinilebilir.

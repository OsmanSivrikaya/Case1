## Merhaba

Görüşmemizde istenilen case'i ben böyle anladım; yanlış anlamış olabilirim, istenilirse düzeltme yapabilirim. 

İstenilen case'de action bazlı attribute ile yapılan role filter sistemini geliştirdim. Ancak süreyi hızlandırmak için bir veritabanı (DB) kullanımına gitmedim. Bunun yerine, fake data olarak listeler tanımladım; bu sayede ilişkisel bir veritabanı gibi davranarak kodu basitleştirmiş oldum. Ayrıca, repository ve service tasarımlarını da kullanmadım; fakat normalde bu tür sistemlerde bu yapılar kullanılmalıdır.

Ek olarak, yetki hatası durumunda bir middleware ile Exception Handling eklenerek hatayı otomatik olarak yakalayıp kullanıcıya hatayı ve hatayla ilgili kodu döndürebilirdik. Bu tür kodlar, istenilen case'in dışına çıkmasına sebep olabileceği ve süreyi kısaltmak için eklemediğim bir unsurdur. Ancak, istenirse, pazartesiye kadar eklenmiş bir şekilde GitHub'daki kodu güncelleyebilirim.

## Ek Bilgi


Bu proje için Policy yapısını kullanarak dinamik izin yönetimi oluşturmak mümkünken, kısa sürede teslim ve projenin mevcut kapsamı nedeniyle bu yaklaşımı tercih etmedim. Policy kullanımı, kullanıcı izinlerini merkezi bir yapı üzerinden yönetme avantajı sunabilirdi.

Veritabanında saklanan izinlerle çalışmak, daha karmaşık bir yapı oluşturmayı gerektirir. Ayrıca, Policy yapılandırması ve gerekli AuthorizationHandler’ların implementasyonu, projenin teslim süresini uzatabilirdi. Ancak, istenilirse, bu yapı eklenebilir ve projeyi daha esnek hale getirecek güncellemeleri yapabilirim.

Vaktiniz olursa githubımdaki diğer projelerimide incelememizi isterim 🙂

## Proje Hakkında

Login için 2 adet kullanıcı tanımladım. Birisi Admin olarak tüm yetkilere sahip diğer kişi moderatör olarak sadece user ile ilgili yetkilere sahip.

Kullanıcı bilgileri:

Kullanıcı Adı: osman
Şifre: 123
Yetki: Admin

Kullanıcı Adı: medine
Şifre: 123
Yetki: Moderatör

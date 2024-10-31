## Merhaba

Görüşmemizde istenilen case'i ben böyle anladım; yanlış anlamış olabilirim, istenilirse düzeltme yapabilirim. 

İstenilen case'de action bazlı attribute ile yapılan role filter sistemini geliştirdim. Ancak süreyi hızlandırmak için bir veritabanı (DB) kullanımına gitmedim. Bunun yerine, fake data olarak listeler tanımladım; bu sayede ilişkisel bir veritabanı gibi davranarak kodu basitleştirmiş oldum. Ayrıca, repository ve service tasarımlarını da kullanmadım; fakat normalde bu tür sistemlerde bu yapılar kullanılmalıdır.

Ek olarak, yetki hatası durumunda bir middleware ile Exception Handling eklenerek hatayı otomatik olarak yakalayıp kullanıcıya hatayı ve hatayla ilgili kodu döndürebilirdik. Bu tür kodlar, istenilen case'in dışına çıkmasına sebep olabileceği ve süreyi kısaltmak için eklemediğim bir unsurdur. Ancak, istenirse, pazartesiye kadar eklenmiş bir şekilde GitHub'daki kodu güncelleyebilirim.

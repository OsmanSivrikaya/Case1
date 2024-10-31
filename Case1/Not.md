## Merhaba

Görüþmemizde istenilen case'i ben böyle anladým; yanlýþ anlamýþ olabilirim, istenilirse düzeltme yapabilirim. 

Ýstenilen case'de action bazlý attribute ile yapýlan role filter sistemini geliþtirdim. Ancak süreyi hýzlandýrmak için bir veritabaný (DB) kullanýmýna gitmedim. Bunun yerine, fake data olarak listeler tanýmladým; bu sayede iliþkisel bir veritabaný gibi davranarak kodu basitleþtirmiþ oldum. Ayrýca, repository ve service tasarýmlarýný da kullanmadým; fakat normalde bu tür sistemlerde bu yapýlar kullanýlmalýdýr.

Ek olarak, yetki hatasý durumunda bir middleware ile Exception Handling eklenerek hatayý otomatik olarak yakalayýp kullanýcýya hatayý ve hatayla ilgili kodu döndürebilirdik. Bu tür kodlar, istenilen case'in dýþýna çýkmasýna sebep olabileceði ve süreyi kýsaltmak için eklemediðim bir unsurdur. Ancak, istenirse, pazartesiye kadar eklenmiþ bir þekilde GitHub'daki kodu güncelleyebilirim.

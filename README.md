# Design Pattern Örnekleri!

Merhabalar, kendimi geliştirmek adına adım attığım bu yolda, aşağıda listesi olan design patternları , .net core 5 ile uygularken bir yandan not alıp diğer yandan da  gerçek dünya projelerini uygulamaya çalışacağım.

 - Strategy Pattern
 - Template Pattern
 - Command Pattern
 - Observer Pattern
 - Chain of Responsibility Pattern
 - Composite Pattern
 - Decorator Pattern
 - Adapter Design Pattern

   ### Design Patternlar 3 yapı altında toplanmaktadır.
   
 - Structural (Yapısal)
 - Behavioral (Davranışsal)
 - Creational (Yaratışsal)

# Strategy Pattern
**Strategy patterni**, yaygın olarak kullanılan tasarım desenlerinden biridir. Strategy Design Pattern'in olayı, **runtime esnasında** bir objenin davranışını değiştirmemize imkan vermesidir. Bir işlemi yapabileceğimiz birden fazla algoritmaya sahipsek bu durumda ilgili pattern kullanılabilir.

Projenin amacı, 2 veritabanı arasında, runtime esnasında istediğini veritabanını seçerek geçiş sağlayabilmesidir. 

![strategy1](https://user-images.githubusercontent.com/57454282/122877928-d41cf500-d33f-11eb-9bd2-5461f459ebc7.png)

> Göründüğü üzere, Strategy design pattern'ı uyguladığımızda ayarlar sekmemizde 2 veritabanı seçeneğimiz gözükmekte. Buradan istediğimiz veritabanı seçimini yapabiliriz.

![strategySqlServer](https://user-images.githubusercontent.com/57454282/122878702-b734f180-d340-11eb-9184-6f90520ba452.png)
> Sql Server'ı seçip verilerimizi ekledikten sonra görüntüleyebildik. Buraya kadar herşey zaten standart. Sonrasında veri tabanımızı **runtime** anında değiştirdik.
> 
![strategyMongoDb](https://user-images.githubusercontent.com/57454282/122878709-b7cd8800-d340-11eb-8772-99bc8693212b.png)
> Bu sayede **runtime** anında veritabanımızı değiştirebildik ve strategy design patterni uygulamış olduk. 

# Template Pattern

**Template patterni** daha çok sıralı operasyonları içeren fonksiyonellikleri ilgilendirmektedir. Öyle ki bu fonksiyonellikler içerisine dahil olan operasyonların bazıları, duruma göre farklı şekillerde uygulanmak istenebilir (Diğer fonksiyonlarda aslında standart olarak hep aynı işi yaparlar) Dolayısıyla fonksiyonelliğin sahiplendiği ve çalışma biçimleri değişkenlik gösterebilecek olan operasyonların kolayca genişletilebilmesi, sahip oldukları **kod parçalarının yeniden kullanılabilirliğinin arttırılması (Code Reusability)** noktasında bir çözüm gerekliliği ortaya çıkmaktadır. **Template pattern** burada çözüm olarak kullanılabilir.

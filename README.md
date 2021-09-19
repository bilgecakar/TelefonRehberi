# TelefonRehberi

Bir kullanıcı için telefon rehberi uygulaması geliştirilecektir. Uygulama ilk çalıştırıldığında kullanıcının karşısına kayıt ekleme ve kayıt listeme seçeneklerinin olduğu pencere açılacaktır. 
Kayıt ekleme seçeneği seçildiğinde açılan pencerede kaydın adı, soyadı ve telefon numarası bilgilerinin girebileceği veri giriş kutuları bulunmaktadır. Her giriş kutusunun yanında bilgiler listelenirken hangi renkte (kırmızı, mavi, yeşil) listeleneceğinin seçilebildiği giriş kutusu bulunmaktadır. Kaydet butonuna tıklandığında “veriler.txt” isimli dosyaya her bir kaydın renk bilgisinin ilk harfi yazıldıktan sonra bir boşluk bırakılarak, devamında ad, soyad ve telefon bilgileri boşluklarla yazılmaktadır. Her kayıt yeni bir satıra yazılacaktır.
Örnek dosya 

kmy ali gel 212

yyy veli git 123

kkk can dan 111

mmm su de 222

ymy nur dan 333



Ana menü penceresinde Kayıt listeleme seçeneği seçildiğinde “veriler.txt” dosyası satır satır okunur. Her satırdaki ad, soyad ve telefon numarası RichTextBox’a aşağıdaki kurallara göre yazılacaktır.

Kurallar:

•	Okunan satırda ilk karakter ‘k’ ise ad kırmızı, ‘m’ ise ad mavi, ‘y’ ise ad yeşil renkte 

•	Okunan satırda ikinci karakter ‘k’ ise soyad kırmızı, ‘m’ ise soyad mavi, ‘y’ ise soyad yeşil renkte 

•	Okunan satırda üçüncü karakter ‘k’ ise numara kırmızı, ‘m’ ise numara mavi, ‘y’ ise numara yeşil renkte yazılacaktır.

•	İlk satırdan başlayarak tek satırlar kalın, çift satırlar kalın olmayan şekilde yazılacaktır.

![deger](https://user-images.githubusercontent.com/36795459/133934806-a72dc8d0-902c-4158-8d07-60f6f800a7bb.png)

 

# Game21

Bir iskambil destesinde bulunan kartların özellikleri bir takımlarının olması ve numaralarının olmasıdır. Takımlar ve numaralar her zaman sabittir bu yüzden onları enum olarak tanımladım.</br>
Farklı oyunlarda bu kartlar farklı anlamlar taşıyabilir. Örneğin 21 oyununda her bir kartın value değeri vardır. Bunun için card sınıfını base alan yeni bir sınıf oluşturdum ve constructorda kartların numaralarına göre alacakları değerleri belirledim.</br>
Örneğin:</br>
ACE 1 ve 11</br>
QUEEN  10</br>
Daha sonra generic bir deste sınıfı açtım bu sınıfa gelen türe göre kart üretimini gerçekleştirdim.</br>
Deck sınıfına parametre olarak Card gelirse klasik kart destesi oluşturuyor. Game21Card gelirse 21 oyunu için özelleştirilmiş deste hazırlıyor.</br>

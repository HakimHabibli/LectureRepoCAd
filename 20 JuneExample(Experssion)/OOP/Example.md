# Kitabxana İdarəetmə Sistemi

Bu sistem kitabxana işlərinin idarə edilməsini asanlaşdırmaq üçün hazırlanmış bir proqramdır.

## Siniflər

### `Book` Sinifi

Bu sinif kitablar haqqında əsas məlumatları saxlayır.

#### Xüsusiyyətlər

- `Name`: Kitabın adı
- `AuthorName`: Müəllifin adı
- `PageCount`: Səhifə sayı
- `Price`: Qiymət
- `Code`: Kitabın kodu (Kitabın adının baş hərfləri və sıra nömrəsi)

### `Library` Sinifi

Bu sinif kitabxananın əsas funksiyalarını idarə edir.

#### Xüsusiyyətlər

- `Books`: `Book` obyektlərinin siyahısı

#### Metodlar

- `AddBook()`: Kitabxanaya yeni kitab əlavə edir.
- `GetBook()`: Verilən şərtlərə uyğun kitabı qaytarır.
- `FindAllBooks()`: Verilən şərtlərə uyğun bütün kitabları qaytarır.
- `RemoveAllBooks()`: Verilən şərtlərə uyğun kitabları silir və silinən kitabların sayını qaytarır.

### `Order` Sinifi

Bu sinif satış proseslərini idarə edir.

#### Xüsusiyyətlər

- `Id`: Sifarişin identifikasiya nömrəsi
- `Books`: Sifariş olunan kitabların siyahısı
- `TotalPrice`: Ümumi qiymət
- `Date`: Sifariş tarixi

#### Metodlar

- Satış prosesini həyata keçirən metod: Sifariş olunan kitabların qiymətlərini hesablayır.

## İstifadə Qaydası

Kitabxana sistemi ilə işləmək üçün əvvəlcə `Library` obyekti yaradın, sonra lazım olan `Book` obyektlərini əlavə edin. Sifariş yaratmaq üçün `Order` obyekti yaradaraq lazımi kitabları əlavə edin və ümumi qiyməti hesablayın.

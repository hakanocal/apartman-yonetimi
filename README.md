# Apartman Site Yönetim Programı
### Sitede bulunan tüm apartmanları, daireleri, yöneticileri, borçları ve personelleri yönetin.
#### Notlar:
- Visual Basic .NET, MsSQL 2012 ve Visual Studio 2012 kullanılarak hazırlandı
- Örnek verilerin olduğu veritabanıyla programı kullanmak için "database/apartmanyonetimi.bak" yedeği geriyüklenmeli
Boş veritabanıyla sıfırdan başlamak için "database/script.sql" çalıştırmalı
- Websitesini bilgisayarınızda sorunsuz bir şekilde çalıştırabilmek için:\
· MsSQL ile script.sql çalıştırılarak Apartman yönetimi veritabanını yüklenmeli\
· ApartmanYonetimi\ApartmanYonetimi\acilis.vb dosyasının en üst kısmında yer alan Public src As String = "..." satırına veritabanı server name'i yazılır\
· ApartmanYonetimi\ApartmanYonetimi\bin\Debug\ApartmanYonetimi.exe çalıştırılarak program başlatılabilir
- Veritabanı tablolarında değişiklik yapıldığında formların kullandığı dataset'i güncellemek için:\
· Project/Other Windows/Data Sources \
· DataSet İsmine sağ tıklayıp "Configurate Data Source With wizard" tıklanır	\
· Tables tablosundan yeni eklenen tabloların tikleri pasif durumda geliyor, pasif durumda olan tablolar aktif edilir ve "Finish" tıklanır\
· GridView'de tabloya ait sütunu görüntülemek için: "Add Colums"



| Giriş/Kayıt      | 
| :-------------: |
| <img src="/images/1giris.jpg">      | 

|  Anasayfa (Giriş yapan yönetici, yetkisi, site bilgileri)             |   
|:-------------:|
| <img src="/images/2anasayfa.jpg">      |
 

| KASA (Gider ve gelir ekleme, kasa bakiyesini görüntüleme)     |  
| :-------------: |
| <img src="/images/3kasa.jpg">     |

|  BİNALAR VE DAİRELER (Bina ve dairelerin yönetimi, taşınma işlemleri, bina ve daire  ekleme, güncelleme, silme işlemleri) &nbsp; &nbsp; &nbsp; &nbsp;         |   
|:-------------:|
|<img src="/images/4binalar-ve-daireler.gif">      |


| BORÇLANDIR (Aidat, kira gibi borçlandırmalar, borç takibi, ödeme alma ve makbuz kesme işlemleri)  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;    |  
| :-------------: |
|<img src="/images/5borclandir.gif">     |

|  PERSONEL BİLGİSİ (Güvenlik görevlisi, temizlikçi, bahçıvan gibi personel bilgilerinin saklanması)             |   
|:-------------:|
| <img src="/images/6personel.jpg">      |



| ARŞİV (Bir problemle karşılaşıldığında geçmişe yönelik yönetici, personel, daire ikamet bilgilerine ulaşılabilmesi) &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;    | 
| :-------------: |
|<img src="/images/7arsiv.gif">      |


|  YÖNETİCİLER (Her yöneticinin sadece yetkilisi olduğu daireleri yönetebilmesi(borçlandırma/daire ekleme,silme,güncelleme gibi). Tam yetkili bir yönetici tüm siteyi ve tüm daireleri yönetebilir ve yönetici ekleme, silme, güncelleme işlemler yapılabilir)             |   
|:-------------:|
| <img src="/images/8yonetici.jpg">     |









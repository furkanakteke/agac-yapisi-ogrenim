# C# Ağaç Yapısı (Tree Data Structure) Konsol Uygulaması

Bu proje, Veri Yapıları (Data Structures) derslerinde işlenen dinamik ağaç modellerinin C# dili ile konsol tabanlı, saf nesne yönelimli programlama (OOP) uygulamasıdır. 

Proje; hiyerarşik veri yönetimini, düğüm (node) ilişkilerini ve rekürsif (öz yinelemeli) algoritmaların arka plan çalışma mantığını somutlaştırmak amacıyla geliştirilmiştir.

---

## 🧠 Proje İçeriği ve Fonksiyonlar

Proje kapsamında bir ağaç yapısı üzerinde gerçekleştirilebilecek tüm temel akademik operasyonlar eksiksiz ve çalışan bir kod mimarisiyle sunulmuştur:

* **Dinamik Eleman Ekleme (`insert`):** Gelen verileri büyüklük kıyaslamasına göre ağacın sol veya sağ dallarına recursive olarak konumlandırır.
* **Gelişmiş Düğüm Silme (`deleteNode`):** Üç farklı silme senaryosunu (hiç çocuğu olmayan yaprak düğüm, tek çocuklu düğüm ve iki çocuklu düğüm durumu) başarıyla yönetir.
* **Ağaç Gezinme (Traversal) Algoritmaları:**
  * 📥 **InOrder:** Ağacı küçükten büyüğe sıralı şekilde gezer.
  * 📋 **PreOrder:** Önce kök (root), sonra sol ve sağ alt dalları gezer.
  * 📤 **PostOrder:** Önce alt dalları, en son ana kökü gezer.
* **Metrik Hesaplamaları:**
  * Ağaçtaki toplam düğüm sayısını (`countNodes`) hesaplar.
  * Ağacın maksimum yüksekliğini/derinliğini (`getHeight`) bulur.
  * Ağacın uç noktalarında yer alan yaprak düğüm sayısını (`yaprak`) hesaplar.

---

## 🛠️ Teknolojiler

* **Dil:** C#
* **Platform:** .NET / Console Application (Konsol Uygulaması)
* **Konsept:** Nesne Yönelimli Programlama (OOP), Referans Yönetimi, Rekürsif Algoritmalar.

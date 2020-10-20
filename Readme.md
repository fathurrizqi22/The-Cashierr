# The Cashier
Aplikasi ini melakukan perhitungan jumlah barang dan jasa kemudian me-list hasil dari perhitungan tersebut, dapat dilakukan berulang kali.

## Fungsionalitas
- User dapat menginputkan nama barang atau jasa.
- User dapat menghitung total harga dan jumlah barang.
- User dapat menambahkan lagi item yang ingin dihitung kemudian terlihat di kotak list.

### How Does It Works?

Perhitungan pada aplikasi ini dilakukan pada class `Item.cs` melalui method dibawah ini dengan mengkalikan jumlah barang dan harga.
```csharp
public double getSubTotal()
        {
            Subtotal = price * quantity;
            return Subtotal;
        }
```


Kemudian konsep single responsibility juga berada pada class `item.cs` seperti pada code dibawah ini
```csharp
private int id;
        public string title { get; set; }

        public int quantity { get; set; }
        public double price { get; set; }
        public double Subtotal { get; set; }
        public string type;

public string getTitle()
        {
            return title;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public string getType()
        {
            return type;
        }
        public double getPrice()
        {
            return price;
        }
        public double getSubTotal()
        {
            Subtotal = price * quantity;
            return Subtotal;
        }
```
dengan membuat terlebih dahulu variabel yang menyimpan `state` kemudian membuat `method` 
masing-masing dari setiap variabel yang telah dibuat.


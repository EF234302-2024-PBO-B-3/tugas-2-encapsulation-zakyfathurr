using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */
// kelas yang buat Reservation dengan atribut private string _CustomerName private string _RoomNumber,Private string _RoomType,private double _PricePerDay,private bool _CheckIn,private bool _CheckOut,private int _Days
// lalu properti public get dan set pada Public string CustomerName,Public string RoomNumber,Public string RoomType,Public double PricePerDay,Public bool CheckIn,Public bool CheckOut,Public int Days
// jika inputan CustomerName,RoomNumber,RoomType null atau "" maka diisi "Unknown"
// jika inputan PricePerDay negatif maka set price 0.0
//jika inputan Days negatif maka set Days 0
//Inputan CheckOut haruslah berkebalikan dengan CheckIn 
//buatlah capsulation dengan parameter string CustomerName,string RoomNumber,string RoomType,double PricePerDay,bool CheckIn,bool CheckOut,int Days
//Buatlah sebuah Metode public untuk menghitung jumlah harga yang harus dibayar Customer,
//Buatlah metode untuk CheckIn dan CheckOut
// ketika Checkout Tampilkan jumlah harga yang harus dibayar 


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

public class Reservation
{
    private string _customerName="";
    private string _roomNumber="";
    private string _roomType="";
    private double _pricePerDay;
    private bool _checkIn;
    private bool _checkOut;
    private int _days;
    public string CustomerName{
        get{return _customerName;}
        set{_customerName = (value == ""|| value ==null)?"Unknown":value;}
    }
    public string RoomNumber{
        get{return _roomNumber;}
        set{_roomNumber = (value == ""|| value == null)?"Unknown":value;}
    }
    public string RoomType{
        get{return _roomType;}
        set{_roomType = (value == ""|| value == null)?"Unknown":value;}
    }
    public double PricePerDay{
        get{return _pricePerDay;}
        set{_pricePerDay = (value < 0)?0.0:value;}
    }
    public bool CheckIn{
        get{return _checkIn;}
        set{_checkIn = value;}
    }
    public bool CheckOut{
        get{return _checkOut;}
        set{_checkOut = value==CheckIn?!CheckIn:value;}
    }
    public int Days{
        get{return _days;}
        set{_days = (value < 0)?0:value;}
    }
    public Reservation(string CustomerName,string RoomNumber,string RoomType,double PricePerDay,int Days,bool CheckIn,bool CheckOut)
    {
        this.CustomerName = CustomerName;
        this.RoomNumber = RoomNumber;
        this.RoomType = RoomType;
        this.PricePerDay = PricePerDay;
        this.CheckIn = CheckIn;
        this.CheckOut = CheckOut;
        this.Days = Days;
    }
    public double CalculateTotalPrice()
    {
        return _pricePerDay * _days;
    }
    public void DoCheckIn()
    {
        CheckIn = true;
        CheckOut =!CheckIn;
    }
    public void DoCheckOut()
    {
        CheckOut = true;
        CheckIn =!CheckOut;
    }
    
}
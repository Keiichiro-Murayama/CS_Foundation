namespace Ex_03_11;
using System.ComponentModel.DataAnnotations;
using Ex_03_11.Modules;
static class Program
{
    static void Main(string[] args)
    {
        IUSB usb1 = new FlashMemory();
        usb1.SendData();
        usb1.ReciveData();

        IUSB usb2 = new Mouse();
        usb2.SendData();

        IUSB usb3 = new Display();
        usb3.ReciveData();
    }
}

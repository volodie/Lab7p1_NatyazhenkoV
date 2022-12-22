using ATM_Computer;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        //RAM ram = new RAM(0, " 8 Gb ", " Hynix ");
        //RAM Secongd_ram = new RAM(0, " 16 Gb ", " Hynix ");
        //HDD hdd = new HDD(1, " 2000 Gb", " Kingston Data Traveler ");
        //HDD Second_hdd = new HDD(2, " 2000 Gb", " Kingston Data Traveler ");

        //Computer PupilComp = new Computer(1500, " Computer For Pupil ", ram, hdd);

        //Computer FatherComp = new Computer(3000, " Computer For Father ");

        //Computer WorkComp = new Computer(5000, " Computer For Work ", Secongd_ram, Second_hdd);

        //Console.WriteLine(PupilComp.GetInformation());
        //Console.WriteLine(FatherComp.GetInformation());
        //Console.WriteLine(WorkComp.GetInformation());

        ATM atm = new ATM(100, 50, 50, 50);
        atm.GetMoney(1200, 10);
    }
}
using System;

class EquipmentUnavailableException : Exception
{
    public EquipmentUnavailableException(string message)
    {
        // TODO: העבירו את הודעת השגיאה לבנאי של מחלקת האב.
    }
}

class EquipmentRoom
{
    private int availableComputers;

    public int AvailableComputers
    {
        get
        {
            return availableComputers;
        }
        set
        {
            // TODO: יש לבדוק שמספר המחשבים אינו שלילי.
            availableComputers = value;
        }
    }

    public EquipmentRoom(int amount)
    {
        AvailableComputers = amount;
    }

    public void Borrow(int amount)
    {
        if (amount > AvailableComputers)
        {
            // TODO: יש לזרוק חריגה מתאימה כאשר אין מספיק מחשבים זמינים.
            return;
        }

        AvailableComputers -= amount;
        Console.WriteLine($"הושאלו {amount} מחשבים בהצלחה.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EquipmentRoom room = new EquipmentRoom(10);

        // יצירת חדר מחשבים עם מספר מחשבים שלילי:
        // לאחר מימוש הבדיקה ב-set, יש לוודא שמצב כזה מטופל כראוי.
        EquipmentRoom invalidRoom = new EquipmentRoom(-3);

        // TODO: יש להוסיף try-catch מתאימים סביב הקריאות שעלולות לזרוק חריגה.

        room.Borrow(4);
        Console.WriteLine("ממשיכים בתוכנית...");

        room.Borrow(8);

        Console.WriteLine("מספר המחשבים הזמינים: " + room.AvailableComputers);
    }
}

namespace FinalProject;

using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
        // dictionary for login
        static Dictionary<string, string> dict_login = new Dictionary<string, string>();


        // dictionary for available rooms
        static Dictionary<string, int> dict_avail = new Dictionary<string, int>();


        // dictionary for unavailable rooms
        static Dictionary<string, int> dict_unavail = new Dictionary<string, int>();

        //dictionary for check-in rooms
        static Dictionary<string, string> dict_checkin = new Dictionary<string, string>();
    static void Main(string[] args)
    {
        dict_login.Add("alice", "alice123");

        dict_avail.Add("101", 2);
        dict_avail.Add("102", 2);
        dict_avail.Add("103", 2);
        dict_avail.Add("104", 2);
        dict_avail.Add("105", 2);
        dict_avail.Add("106", 3);
        dict_avail.Add("107", 3);
        dict_avail.Add("108", 3);
        dict_avail.Add("109", 3);
        dict_avail.Add("110", 4);

        Console.WriteLine("----CIDM2315 Final Project: Tina Coppedge----");

        Console.WriteLine("----Welcome to Buff Hotel----");

        bool login_result = user_login(dict_login);
        while(login_result)
        {
            Console.WriteLine("--> Please Select from the following options<--");
            Console.WriteLine("1) Show Available Rooms");
            Console.WriteLine("2) Check-In");
            Console.WriteLine("3) Show Reserved Rooms");
            Console.WriteLine("4) Check Out");
            Console.WriteLine("5) Log Out");

            string choice = Console.ReadLine();
            
            if(choice =="1")
            {
                show_avail_rooms(dict_avail);
            }
            else if(choice == "2")
            {
                room_check_in(dict_avail, dict_unavail, dict_checkin);
            }
            else if(choice == "3")
            {
                show_res_rooms(dict_checkin);
            }
            else if(choice == "4")
            {
                room_check_out(dict_avail, dict_unavail, dict_checkin);
            }
            else if(choice == "5")
            {
                Console.WriteLine("----Logout Successful----");
                break;
            }
            else
            {
                Console.WriteLine("----Invalid Selection. Please Try Again!----");
                return;
            }
        }
    }

    //Selection log in
    public static bool user_login(Dictionary<string, string> dict_login)
    {
        Console.WriteLine("-->Please input your username<--");
        string username = Console.ReadLine();

        Console.WriteLine("-->Please input your password<--");
        string password = Console.ReadLine();

        if(dict_login.ContainsKey(username))
        {
            if(dict_login[username] == password)
            {
                Console.WriteLine($"----Login Successful: Welcome {username}----");

                return true;
            }
            else
            {
                Console.WriteLine("----Wrong Password----");
                return false;
            }
        }
        else
        {
            Console.WriteLine("----User does not exist----");
            return false;
        }
    }

    //Selection for Show Available Rooms
    public static void show_avail_rooms(Dictionary<string, int> dict_avail)
    {
        int room_index = 0;
        foreach(var room in dict_avail)
        {
            Console.WriteLine($"{room_index} - Room: {room.Key} - Capacity: {room.Value}");
            room_index++;
        }

        Console.WriteLine($"\n----Number of rooms available: {dict_avail.Count}----\n");
    }

    //Selection for Show Reserved Rooms

    public static void show_res_rooms(Dictionary<string, string> dict_checkin)
    {
        int room_index = 0;
        foreach(var room in dict_checkin)
        {
            Console.WriteLine($"{room_index} - Room: {room.Key} - Customer: {room.Value}");
            room_index++;
        }

        Console.WriteLine($"\n----Number of reserved rooms: {dict_checkin.Count}----\n");
    }
    
    //Selection for Check In -- do I need Dictionary? If so do I also need both dict_avail and dict_unavail? How?
    public static void room_check_in(Dictionary<string, int> dict_avail, Dictionary<string, int> dict_unavail, Dictionary<string, string> dict_checkin)
    {
        Console.WriteLine(">--Please Enter Number of Guests<--");

        int guests = Convert.ToInt16(Console.ReadLine());

        int room_index = 0;
        bool suitableRoomFound = false; //ChatGPT helped with adding the bool suitableRoomFound within this method code

        foreach (var room in dict_avail)
        {

                if (guests <= room.Value)
                {
                    Console.WriteLine($"{room_index} - Room: {room.Key} - Capacity: {room.Value}");
                    room_index++;
                    suitableRoomFound = true;
                }
        }

        if (!suitableRoomFound)
        {
            Console.WriteLine("----There are currently no suitable rooms----");
            return;
        }

        //check in process

        Console.WriteLine("-->Please input room number<--");
        string res_room = Console.ReadLine();
        bool matchingRoomFound = false;

        foreach(var room in dict_avail)
        {
            //room_index = 0;

            if(res_room == room.Key)
            {
                matchingRoomFound = true;
                Console.WriteLine("-->Please input customer name<--");
                string customer_name = Console.ReadLine();
                Console.WriteLine("-->Please input customer email<--");
                string customer_email = Console.ReadLine();
                Console.WriteLine("-->Please select y to confirm or hit any other key to cancel<--");
                string customer_selection = Console.ReadLine();

                if(customer_selection == "y")
                {
                    Console.WriteLine("----Check-In successful!----");
                    string chosen_room = room.Key;
                    int room_capacity = room.Value;
                    dict_unavail.Add(chosen_room, room_capacity);
                    dict_checkin.Add(res_room, customer_name);
                    dict_avail.Remove(res_room);
                }
                else
                {
                    Console.WriteLine("----Check in canceled----");
                    return;
                }
                
            }
        }

        if(!matchingRoomFound)
        {
            Console.WriteLine("----There are no current rooms that match your selection. Please try again----");
            return;
        }
    }

    //Selection for Check Out

    public static void room_check_out(Dictionary<string, int> dict_avail, Dictionary<string, int> dict_unavail, Dictionary<string,string> dict_checkin)
    {
        Console.WriteLine("-->Please enter customer room number>--");
        string res_room = Console.ReadLine();
        Console.WriteLine("-->Please enter customer name<--");
        string res_name = Console.ReadLine();
        int room_index = 0;
        bool reservedRoomFound = false;
        
        foreach(var room in dict_unavail)
        {
            //room_index = 0;

            if(room.Key == res_room)
            {
                Console.WriteLine($"----{room_index} - Room: {room.Key} - Customer: {res_name}----");
                Console.WriteLine("-->To confirm check out please press y, or press any key to cancel<--");
                string confirm_checkout = Console.ReadLine();
                reservedRoomFound = true;

                if(confirm_checkout == "y")
                {
                    dict_avail.Add(res_room, dict_unavail[res_room]);
                    dict_unavail.Remove(res_room);
                    dict_checkin.Remove(res_room);
                    Console.WriteLine("----Check out successful----");
                }
                else
                {
                    Console.WriteLine("----Check out canceled----");
                }
            }
        }

        if(!reservedRoomFound)
        {
            Console.WriteLine("----No reserved room found. Please try again----");
            return;
        }
    }
}
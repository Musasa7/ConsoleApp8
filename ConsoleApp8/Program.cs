
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NAudio.Wave; // Ensure NAudio is included for audio playback

class CybersecurityChatbot
{
    static void Main(string[] args)
    {
        // Voice greeting
        PlayGreeting();

        // ASCII art logo
        DisplayAsciiArt();

        // The beginning of user interaction
        GetUserName();

        // Start the interactive dialogue
        HandleUserInput();
    }

    static void PlayGreeting()
    {
        string filePath = @"C:\Users\hustl\source\repos\ConsoleApp8\ConsoleApp8\audio\synthesize.wav";

        try
        {
            // Audio greeting playing 
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Playing audio... Press any key to continue.");
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops! Something went wrong while playing the audio: {ex.Message}");
        }
    }

    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@" ▄▄▄▄    ██▀███  ▓█████ ▄▄▄       ██ ▄█▀  
▓█████▄ ▓██ ▒ ██▒▓█   ▀▒████▄     ██▄█▒   
▒██▒ ▄██▓██ ░▄█ ▒▒███  ▒██  ▀█▄  ▓███▄░   
▒██░█▀  ▒██▀▀█▄  ▒▓█  ▄░██▄▄▄▄██ ▓██ █▄   
░▓█  ▀█▓░██▓ ▒██▒░▒████▒▓█   ▓██▒▒██▒ █▄  
░▒▓███▀▒░ ▒▓ ░▒▓░░░ ▒░ ░▒▒   ▓▒█░▒ ▒▒ ▓▒  
▒░▒   ░   ░▒ ░ ▒░ ░ ░  ░ ▒   ▒▒ ░░ ░▒ ▒░  
 ░    ░   ░░   ░    ░    ░   ▒   ░ ░░ ░   
 ░         ░        ░  ░     ░  ░░  ░     
      ░                                   
 ██▓███   ▒█████   ██▓ ███▄    █ ▄▄▄█████▓
▓██░  ██▒▒██▒  ██▒▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒
▓██░ ██▓▒▒██░  ██▒▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░
▒██▄█▓▒ ▒▒██   ██░░██░▓██▒  ▐▌██▒░ ▓██▓ ░ 
▒██▒ ░  ░░ ████▓▒░░██░▒██░   ▓██░  ▒██▒ ░ 
▒▓▒░ ░  ░░ ▒░▒░▒░ ░▓  ░ ▒░   ▒ ▒   ▒ ░░   
░▒ ░       ░ ▒ ▒░  ▒ ░░ ░░   ░ ▒░    ░    
░░       ░ ░ ░ ▒   ▒ ░   ░   ░ ░   ░      
             ░ ░   ░           ░          
");
    }

    static void GetUserName()
    {
        string firstName;
        string lastName;

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine();

            if (!IsValidName(firstName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: First name must not contain special characters. Please use only letters, digits, spaces");
                continue; // Prompt for first name again
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine();

            if (!IsValidName(lastName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Last name must not contain special characters. Please use only letters, digits, spaces");
                continue; // Prompt for last name again
            }

            Console.WriteLine($"Hello, {firstName} {lastName}!");
            break; // Valid names entered, exit the loop
        }
    }

    static bool IsValidName(string name)
    {
        // Regex to allow only specified characters
        string pattern = @"^[a-zA-Z0-9\s]*$";
        return Regex.IsMatch(name, pattern);
    }

    static void HandleUserInput()
    {
        // Basic response system
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeWithDelay("Here are the questions you can ask me:\n" +
               "1. Cybersecurity\n" +
               "2. Importance\n" +
               "3. Threats\n" +
               "4. Safety\n" +
               "5. Malware\n" +
               "6. Firewalls\n" +
               "7. Encryption\n" +
               "8. Updates\n" +
               "9. VPN\n" +
               "10. Phishing\n" +
               "(or type 'exit' if you want to leave):");
            string question = Console.ReadLine().ToLower();

            if (question == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("have a great day. Goodbye!");
                break;
            }

            // Respond to specific questions
            RespondToQuestion(question);
        }
    }

    static void RespondToQuestion(string question)
    {


        
        if (question.Contains("how are you"))
            {
            
            TypeWithDelay("I'm okay, thanks for asking! I'm here to help you with all your break Point cybersecurity questions.");
}
        else if (question.Contains("what's your purpose"))
{
             TypeWithDelay("the mission is to help you stay safe online by sharing tips about password security, phishing, and safe browsing.");
}
        else if (question.Contains("cybersecurity"))
        {
            TypeWithDelay("Cybersecurity refers to any technologies, practices, and policies for preventing cyberattacks or mitigating their impact. It aims to protect computer systems, applications, devices, data, financial assets, and people against ransomware and other malware, phishing scams, data theft, and other cyber threats.");
        }
        else if (question.Contains("importance"))
        {
            TypeWithDelay("Protecting sensitive information, preventing cyber attacks, and maintaining system integrity are just a few reasons why cybersecurity should be a top priority for individuals, businesses, and even national governments.");
        }
        else if (question.Contains("threats"))
        {
            TypeWithDelay("Common cybersecurity threats include: viruses, phishing attacks, and ransomware. Understanding these threats is vital to implementing effective defenses.");
        }
        else if (question.Contains("safety"))
        {
            TypeWithDelay("To ensure safety online, individuals should use strong, unique passwords, enable two-factor authentication, and be cautious about sharing personal information.");
        }
        else if (question.Contains("malware"))
        {
            TypeWithDelay("Malware is a broad category of malicious software designed to harm or exploit any programmable device or network. Types include viruses, worms, trojans, and spyware.");
        }
        else if (question.Contains("firewalls"))
        {
            TypeWithDelay("Firewalls act as barriers between trusted internal networks and untrusted external networks, monitoring and controlling traffic based on security rules.");
        }
        else if (question.Contains("encryption"))
        {
            TypeWithDelay("Encryption is the process of converting information into a code to prevent unauthorized access, ensuring that intercepted data remains unreadable.");
        }
        else if (question.Contains("updates"))
        {
            TypeWithDelay("Regular software updates are critical as they address vulnerabilities and bugs that could be exploited by attackers.");
        }
        else if (question.Contains("vpn"))
        {
            TypeWithDelay("A Virtual Private Network (VPN) creates a secure, encrypted connection over a less secure network, protecting users' internet activity.");
        }
        
        else if (question.Contains("phishing"))
        {
            
            TypeWithDelay("Phishing is a type of cyber attack where attackers impersonate legitimate organizations to trick individuals into providing sensitive information.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            TypeWithDelay("Hmm, try asking it in a different way?");
        }
    }
   
    
    static void TypeWithDelay(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        foreach (char c in message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(c);
            System.Threading.Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
    }
}
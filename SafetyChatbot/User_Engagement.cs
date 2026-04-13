using System;

namespace SafetyChatbot
{
    public class User_Engagement
    {
        User obj = new User();

        public void promptUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[   Welcome to safetybotAnetor, the bot that cares about your cyber!   ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************************************************\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: ");
            obj.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nNice meeting you {obj.Name}. Let me take you through a journey of Cybersecurity.");
            Console.WriteLine($"What would you like to know {obj.Name}?");
            try {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n{obj.Name}: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string input = Console.ReadLine().ToLower();

                    if (input == "exit")
                    {
                        Console.WriteLine("Goodbye! Stay safe online!");
                        //break;
                    }
                    else if (input.Contains("how are you"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("I'm good, thanks! Just waiting to help with the information you need!");

                    }
                    else if (input.Contains("hi") || input.Contains("hello") || input.Contains("hey"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hey there! " + obj.Name);
                    }
                    else if (input.Contains("your purpose"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("My purpose is to help protect systems by answering your questions!");
                    }
                    else if (input.Contains("what can i ask"))
                    {
                        ShowMenu();
                    }
                    else if (input == "exit")
                    {
                        exit();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unsupported entry. Try asking 'what can i ask' or type 'exit'.");

                    }


                   
                }
            }
            catch
             (FormatException)
            {
                Console.WriteLine("Bot: Please enter a valid input!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Bot: That number is too large, please try again!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bot: Something went wrong - " + ex.Message);
            }

            Console.WriteLine();

        }
            

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nChoose a topic (1-8):");
            Console.ForegroundColor = ConsoleColor.Red;
            //This is the menu 
            Console.WriteLine("1. What is Cybersecurity\n" +
                "2. Phishing\n" +
                "3. Cyber Attacks\n" +
                "4. Auth & Access\n" +
                "5. Device Security\n" +
                "6. Data Handling\n" +
                "7. Awareness\n" +
                "8. Incident Response\n" +
                "9. Exit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Option: ");

            // This prevents the crash if the user types a non-number
            Console.ForegroundColor = ConsoleColor.Green;
            if (int.TryParse(Console.ReadLine(), out int option))// used the 'TryParse' so that i could avoid the code crashing 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                switch (option)
                {
                    case 1: cyberSecurity();
                        break;
                    case 2: Phishing();
                        break;
                    case 3: CyberAttacks(); 
                        break;
                    case 4: AuthAccess();
                        break;
                    case 5: Device();
                        break;
                    case 6: DataHandling();
                        break;
                    case 7: SecurityAwareness();
                        break;
                    case 8: IncidentResponse();
                        break;
                    case 9: exit();
                        break;
                    default: Console.WriteLine("Please choose 1-8."); 
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            
        }

       
        

        // this is where all the cyber security educational information is

        public void cyberSecurity()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Cybersecurity Is and Why It Matters\r\n" +
                "Cybersecurity is the practice of protecting your digital devices, networks, and personal information from theft, damage, or unauthorized access. " +
                "Think of it as the digital equivalent of locking your doors and windows—it’s a set of tools, habits, and safeguards designed to keep the wrong people out of your online life." +
                " While many people imagine sophisticated hackers breaking through complex code, the reality is far simpler: most cyberattacks are opportunistic and target easy mistakes." +
                " That’s why cybersecurity isn’t just about software; it’s equally about your daily behavior, such as recognizing suspicious messages, using strong passwords, and" +
                " keeping apps updated.");
            Console.WriteLine();
            Console.WriteLine("");

        }
        public void Phishing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Phishing is a type of cyberattack where a scammer pretends to be a trusted person, company, or organization to trick you into revealing sensitive information, " +
                "such as your passwords, credit card numbers, or bank account details. These attacks almost always arrive in the form of an email, text message, or direct message that appears legitimate, " +
                "often using fake logos, urgent language, or threats like \"your account will be closed\" to create panic. The message typically contains a link that leads to a fake website designed to steal your login credentials, " +
                "or an attachment that installs malware on your device. For example, you might receive an email that looks exactly like it's from your bank, asking you to \"verify your account\" by clicking a link and entering your username and " +
                "password—but the website is a copycat controlled by the attacker. The best defense against phishing is to slow down, inspect the sender's email address closely (it often has small misspellings), avoid clicking links in unexpected messages, " +
                "and never enter personal information after arriving from a link sent to you. When in doubt, contact the company or person directly using a phone number or website you know is real, not the contact information provided in the suspicious message.");
        }
        public void CyberAttacks()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Phishing is by far the most widespread cyber attack, and it targets you directly rather than your computer." +
                " In a phishing attack, the attacker sends a fake email, text message, or direct message pretending to be a legitimate company like your bank, a delivery service, or even a coworker." +
                " The message usually creates urgency—\"Your account will be closed in 24 hours\"—and tricks you into clicking a malicious link or downloading an infected attachment. " +
                "Once you click, you may be sent to a fake login page that steals your password, or malware installs silently on your device." +
                " Phishing works because it exploits human nature, not technical flaws, which is why it remains the number one threat to individuals and organizations alike." +
                "\r\n\r\nMalware is a broad category that includes viruses, worms, spyware, and trojans. Malware is malicious software designed to damage, disrupt, or gain unauthorized access to your device. " +
                "You typically get infected by clicking a bad link, downloading an infected file, or using an infected USB drive. Once installed, malware can do many things: delete your files, steal your passwords, record your keystrokes," +
                " or turn your computer into a zombie that attacks other systems without your knowledge.\r\n\r\nRansomware is a particularly nasty form of malware that has become extremely common in recent years. " +
                "When ransomware infects your computer, it encrypts all your personal files—documents, photos, videos—making them completely inaccessible. The attacker then displays a message demanding payment, " +
                "usually in cryptocurrency like Bitcoin, in exchange for the decryption key. Even if you pay, there is no guarantee you will get your files back. Ransomware often spreads through phishing emails or by exploiting outdated software, " +
                "which is why keeping backups of your important files on a separate drive or cloud service is critical.\r\n\r\nMan-in-the-Middle (MitM) attacks occur when an attacker secretly intercepts communication between two parties, " +
                "such as between you and your bank's website. This often happens on unsecured public Wi-Fi networks, like those in coffee shops or airports. The attacker can read your messages, steal login credentials, or even alter the information being sent without either side knowing. " +
                "Using a VPN (Virtual Private Network) and avoiding sensitive activities on public Wi-Fi are the best protections against this type of attack.\r\n\r\nDenial-of-Service (DoS) and Distributed Denial-of-Service (DDoS) attacks aim to make a website or online service unavailable by flooding it with so much fake traffic that it crashes under the load." +
                " While these attacks usually target companies, not individual users, you can experience the effects when your favorite website or online game becomes slow or completely unreachable. Attackers often use networks of infected computers (called botnets) to launch these massive attacks.\r\n\r\nPassword attacks come in several forms, " +
                "but all share the same goal: gaining access to your accounts by cracking or stealing your password. In a brute force attack, automated software tries millions of password combinations until it finds the right one. In credential stuffing, attackers take passwords leaked from one data breach and try them on other websites," +
                " betting that you reuse the same password everywhere. This is why using unique, strong passwords for each account and enabling multi-factor authentication (MFA) is so important.\r\n\r\nSQL Injection attacks target websites and databases rather than individual users directly. When a website has poor security, an attacker can type specially crafted commands into a search box " +
                "or login form that tricks the website's database into revealing its contents. This can expose massive amounts of user data, including passwords, credit card numbers, and personal messages. As a user, you cannot prevent SQL injection directly, but you can protect yourself by using unique passwords and monitoring your accounts for suspicious activity after a company announces a data breach." +
                "\r\n\r\nZero-day attacks exploit security vulnerabilities that the software maker does not yet know about, meaning there is no fix available at the time of the attack. These are highly valued by sophisticated attackers and are often used in targeted attacks against governments, large corporations, or high-value individuals. " +
                "For the average user, the best defense is to enable automatic updates on all software—when a fix is eventually released, you want it installed immediately.");
        }
        public void AuthAccess()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Authentication?\r\n" +
                "Authentication is the process of proving that you are who you say you are. In simple terms, it's how a system verifies your identity before letting you in. " +
                "Think of it like showing your ID at an airport security checkpoint—you claim to be a specific person, and you must provide evidence to support that claim." +
                " In the digital world, authentication usually happens when you log into an email account, a banking app, or your work computer. " +
                "The most common form of authentication is a password, but passwords alone are no longer considered sufficient because they can be stolen, guessed, or leaked in data breaches. " +
                "That is why modern systems rely on stronger methods, which brings us to the concept of multi-factor authentication.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Access Control?\r\n" +
                "While authentication answers the question \"Who are you?\", access control answers the question \"What are you allowed to do?\" Once the system knows your identity, " +
                "it uses access control rules to determine which resources you can see and which actions you can perform. For instance, a regular employee might be able to view customer names but " +
                "not delete their records, while a manager might have permission to both view and delete. A customer using a banking app can check their own balance but cannot see other customers' accounts." +
                " Access control ensures that people only have the minimum level of permission necessary to do their jobs or use a service—a principle known as \"least privilege.\"");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("How Authentication and Access Work Together\r\n" +
                "Authentication and access control work as a two-step process every time you interact with a secured system." +
                " First, you present your credentials (username and password, plus possibly a code from your phone or a fingerprint scan). The system authenticates you, confirming your identity." +
                " Second, after you are authenticated, the system checks its access control rules to decide what you are allowed to see or do." +
                " If you try to perform an action you are not authorized for, the system blocks you even though you are successfully logged in. This two-layer approach is why you can log into your work email but not your boss's payroll files, " +
                "and why you can see your own bank transactions but not your neighbor's. Without authentication, anyone could claim to be you. Without access control, once someone logged in, they could do anything. " +
                "Together, they form the foundation of digital security.");

        }
        public void Device()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Device Security?\r\nDevice security simply means keeping the devices you use every day safe from threats." +
                " Your devices include your laptop, desktop computer, smartphone, tablet, and even things like smartwatches or home assistants." +
                " Think of device security like locking your car or your front door. You wouldn't leave your car unlocked with the keys inside, and you shouldn't leave your computer or phone unprotected either. " +
                "Device security covers everything from using a screen lock and keeping your software updated to installing antivirus software and being careful what you download." +
                " Every device that connects to the internet is a potential target, because hackers constantly scan for unprotected devices they can break into." +
                "\r\n\r\nWhat Is an Endpoint?\r\nAn endpoint is just a fancy name for any device that connects to a network. In a business or organization," +
                " the \"network\" might include hundreds or thousands of devices — employee laptops, office desktops, company phones, printers, and even security cameras. " +
                "Each one of these is called an endpoint because it sits at the \"end\" of the network connection. At home, your phone, laptop, and tablet are all endpoints too." +
                " The term matters because hackers often try to break into a network by attacking the weakest endpoint. For example, instead of attacking a company's main servers directly, " +
                "a hacker might send a phishing email to one employee, infect that employee's laptop, and then use that laptop to jump into the rest of the company's network.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Why Device and Endpoint Security Matters\r\n" +
                "Your devices hold your personal information — photos, messages, emails, passwords, bank details, and more. " +
                "If someone gains access to your device, they basically gain access to your digital life. They can steal your identity, " +
                "empty your bank account, lock your files for ransom, or use your device to attack others without you even knowing." +
                " In a workplace, a single infected laptop can lead to a company-wide data breach that affects thousands of customers. " +
                "The scary part is that most attacks don't come from sophisticated hacking. " +
                "They come from simple mistakes: someone didn't install an update, clicked a bad link, or turned off their antivirus because it was annoying." +
                "\r\n\r\n" +
                "How to Protect Your Devices and Endpoints\r\nThe good news is that protecting your devices doesn't require a technical degree." +
                " Here are the basics that everyone should do.\r\n\r\nKeep everything updated. Those update notifications that pop up on your phone or computer aren't just for new features." +
                " They almost always include security patches that fix holes hackers could use to break in. Turn on automatic updates so you don't have to remember." +
                "\r\n\r\nInstall and run antivirus software." +
                " This is your first line of defense. Good antivirus software scans for known threats, blocks malicious downloads, and warns you about dangerous websites." +
                " Most computers come with built-in antivirus (like Windows Defender) that works fine — just make sure it's turned on.\r\n\r\nLock your devices when you step away." +
                " This sounds obvious, but many people skip it. If you walk away from your computer at a coffee shop or even at work, someone could sit down and access everything." +
                " Get in the habit of pressing Windows+L on a PC or locking your phone screen every time.\r\n\r\nBe careful what you plug in. USB drives can carry malware. " +
                "Never plug in a random USB drive you found or someone gave you. If you use USB drives for backups, only use ones you trust.\r\n\r\nDon't ignore your phone. " +
                "Many people focus on protecting their computer but treat their phone like it's not a real computer. Your phone is absolutely a computer, and it contains even more personal information than your laptop." +
                " Keep your phone updated, use a strong screen lock (not just swipe to open), only download apps from official app stores, and be careful what permissions you give to apps." +
                "\r\n\r\nUse separate devices for separate purposes if you can." +
                " If you use your work laptop for personal browsing and downloading random software, you put your employer's data at risk. Similarly, " +
                "don't do banking on a shared family computer that everyone uses to download games. When possible, keep work devices for work and personal devices for personal use." +
                "\r\n\r\nWhat Happens If a Device Gets Compromised\r\nIf you suspect your device has been hacked or infected, act quickly. First, disconnect it from the internet — turn off Wi-Fi or unplug the network cable. " +
                "This stops the attacker from doing further damage or stealing more data. Then run a full antivirus scan. If the scan finds something, follow its instructions to remove the threat." +
                " Change your important passwords (email, banking, social media) using a different, clean device. " +
                "If the device still acts strange, you may need to back up your important files and completely reinstall the operating system — a \"factory reset.\" In a workplace, never try to hide an incident." +
                " Report it to your IT department immediately. The faster you act, the less damage an attacker can do.");
        }
        public void DataHandling()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Data Handling?\r\n" +
                "Data handling simply means how you collect, use, store, share, and delete information." +
                " Any time you type a password, save a photo, send an email, or enter your address on a website, you are handling data. In everyday life, " +
                "you handle data constantly without thinking about it. But how you handle that data matters because data can be stolen, lost, " +
                "or misused. Good data handling means treating information with care — whether it is your own personal information or someone else's.\r\n\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Types of Data You Handle Every Day\r\n" +
                "Not all data is equally sensitive, but all data deserves some level of care. " +
                "Public data is information that is already out in the open, like your name on a social media profile or your business email address. " +
                "Internal data is meant for limited sharing, like a family group chat or a work team document. Sensitive data is the most important to protect. " +
                "This includes your passwords, bank account numbers, medical records, social security number, private photos, and messages you would not want strangers to see. " +
                "In a workplace, sensitive data might include customer information, employee records, financial reports, or trade secrets." +
                " The rule is simple: the more damage someone could do with the information, the more carefully you should handle it.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What to Do If Data Is Lost or Leaked\r\n" +
                "If you accidentally share something you should not have, or if you lose a device containing sensitive information, do not panic and do not try to hide it." +
                " Act quickly. If it is your own data, change affected passwords immediately, check your accounts for suspicious activity," +
                " and consider freezing your credit if financial information was involved. If it is company data or someone else's data, " +
                "report it to the right person right away — your manager, IT department, or the person you accidentally shared with. The faster you report a mistake, " +
                "the faster people can take steps to limit the damage. Trying to hide a data handling mistake almost always makes things worse. Honest mistakes happen." +
                " Covering them up is a choice.");

        }
        public void SecurityAwareness()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Security Awareness?\r\n" +
                "Security awareness simply means paying attention to security in your everyday digital life." +
                " It is not a tool you install or a password you create. It is a mindset — a habit of thinking before you click, " +
                "stopping before you share, and noticing when something feels wrong. Think of it like crossing the street. " +
                "You do not just step into traffic without looking. You look both ways, you pay attention to the light, and you watch for cars that are not stopping." +
                " Security awareness is exactly the same, but for the digital world. It is the difference between automatically clicking a link and pausing to ask," +
                " \"Does this look right?\"");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Why Security Awareness Matters\r\n" +
                "Most cyber attacks succeed not because hackers are geniuses, but because people make quick mistakes. " +
                "Someone clicks a link without thinking. Someone uses the same password everywhere. Someone ignores an update because it popped up at a bad time." +
                " Hackers know this, so they target human behavior instead of computer code. That is why security awareness is so important." +
                " Technology like antivirus software and firewalls can stop many attacks, but they cannot stop you from willingly typing your password into a fake website. " +
                "You are the last line of defense. The good news is that you do not need to be a technical expert." +
                " You just need to pay attention and learn a few simple habits.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Spotting Red Flags\r\n" +
                "Security awareness means learning to recognize the warning signs of a scam." +
                " Here are the most common red flags to watch for.\r\n\r\nBad grammar and spelling mistakes. Real companies hire professional writers. " +
                "Scammers often make obvious errors.\r\n\r\nUrgent or threatening language. " +
                "\"Act now or your account will be deleted.\" Legitimate companies do not threaten you.\r\n\r\nRequests for personal information." +
                " No real bank, tech support team, or government agency will ask for your password, your multi-factor authentication code," +
                " or your social security number by email, text, or phone call.\r\n\r\nSuspicious links. Hover your mouse over a link before you click (without clicking)." +
                " Does the web address look strange? Does it have misspellings like \"arnazon.com\" instead of \"amazon.com\"?\r\n\r\nToo good to be true. " +
                "You did not win a contest you never entered. A stranger is not giving you free money.\r\n\r\nUnexpected attachments. If you were not expecting a file," +
                " do not open it — even if it looks like it came from a friend. " +
                "Your friend's account might have been hacked.\r\n\r\nGeneric greetings. \"Dear customer\" instead of using your real name." +
                " Real companies know who you are.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Creating Good Security Habits\r\n" +
                "Awareness is not useful unless it turns into action." +
                " Here are simple habits to build into your daily life.\r\n\r\nUse a password manager." +
                " You cannot remember dozens of strong, unique passwords. A password manager does it for you.\r\n\r\nTurn on multi-factor authentication everywhere it is offered." +
                " This single habit stops most attacks.\r\n\r\nUpdate your software when it asks." +
                " Do not click \"remind me later\" more than once.\r\n\r\nBack up your important files. " +
                "If ransomware hits, backups save you.\r\n\r\nCheck your accounts regularly. Look for logins or transactions you do not recognize.\r\n\r\nReport anything strange." +
                " If you see something suspicious, tell someone — your IT department, your bank, or just a friend who can help you figure it out.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What to Do If You Mess Up\r\n" +
                "Everyone makes mistakes. Security awareness is not about being perfect." +
                " It is about catching mistakes quickly. If you click a link you should not have, if you realize you gave your password to a fake website, " +
                "or if you lost your phone, do not panic and do not hide it. Act fast. Disconnect from the internet if you are on a computer." +
                " Change your passwords from a different device. Run a virus scan. If it involves work, tell your IT department immediately." +
                " If it involves your bank, call them right away. The faster you act, the less damage can happen. And do not beat yourself up." +
                " Hackers are good at what they do. Learn from the mistake and move on.");
        }
        public void IncidentResponse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Incident Response?\r\n" +
                "Incident response is what you do when something goes wrong with your cybersecurity. " +
                "It is your emergency plan — the digital equivalent of knowing what to do if a fire starts in your kitchen." +
                " A \"security incident\" can be anything from clicking a bad link and realizing it too late, to your phone being stolen, " +
                "to seeing a weird charge on your bank statement, to being locked out of your own files by ransomware." +
                " Incident response is simply the steps you take to stop the damage, clean up the mess, and get back to normal as quickly as possible. " +
                "Having a plan ahead of time is critical because when an attack happens, people panic. A plan gives you something to follow so you do not have to think clearly under pressure.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Five Simple Steps of Incident Response\r\n" +
                "You do not need a complicated plan. Just remember these five steps: Prepare, Detect, Contain, Remove, and Recover." +
                "\r\n\r\nStep 1: Prepare. This happens before anything goes wrong." +
                " Preparation means having your defenses in place: strong passwords, multi-factor authentication turned on, regular backups of your important files, and antivirus software running." +
                " It also means knowing who to call. For your bank's fraud department, save their phone number now." +
                " For your work IT department, know how to reach them after hours. Preparation is like buying a fire extinguisher and smoke detector before you need them." +
                "\r\n\r\nStep 2: Detect. Detection is realizing something is wrong. You might see a strange charge on your credit card." +
                " You might get an email saying someone logged into your account from a different country. You might click a link and immediately think, " +
                "\"Oh no, that was a mistake.\" You might find that your files will not open and a message is demanding money. Pay attention to those feelings." +
                " Trust your gut. The sooner you detect an incident, the less damage an attacker can do.\r\n\r\nStep 3: Contain. Containment means stopping the damage from getting worse. " +
                "If you clicked a bad link, disconnect that device from the internet immediately. If you see a strange login on your email account, change your password right away." +
                " If you lost your phone, use a friend's phone or a computer to remotely lock it or wipe it. If you are at work and something seems wrong, unplug the network cable from your computer. " +
                "The goal of containment is to limit the attack. Think of it like closing the door to keep a fire from spreading to the rest of the house.\r\n\r\nStep 4: Remove." +
                " Removal means getting the bad stuff out of your system. Run a full antivirus scan and let it delete anything it finds. " +
                "Change your passwords from a clean device (not the one that might be infected). Remove any apps or browser extensions you do not recognize." +
                " If the infection is bad enough, you might need to completely wipe your computer and reinstall everything from scratch." +
                " That is a pain, but it is better than letting the attacker stay hidden on your system.\r\n\r\nStep 5: Recover." +
                " Recovery means getting back to normal. Restore your files from your backups. Log back into your accounts. Turn multi-factor authentication back on if it got turned off." +
                " Check your accounts for any damage the attacker might have done, like sending emails from your account or changing your recovery information. Then, learn from what happened." +
                " How did the incident start? What could you have done differently? Use that lesson to make your security stronger so it does not happen again.\r\n\r\n");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Not to Do During an Incident\r\n" +
                "When something goes wrong, people often make things worse. Do not panic." +
                " Panic leads to bad decisions. Do not try to delete evidence. If you are at work, do not delete files or try to cover your tracks." +
                " Do not pay a ransom if you can avoid it." +
                " Paying does not guarantee you will get your files back, and it marks you as someone who pays, which can lead to more attacks." +
                " Do not ignore the problem hoping it will go away. It will not." +
                " The longer you wait, the worse the damage gets. Do not share details publicly, like posting on social media that your account was hacked." +
                " That can confuse your friends and make it harder to sort out what happened. And do not beat yourself up. Everyone makes mistakes." +
                " The important thing is how you respond.");

        }
        public void SafeBrowsing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Safe Browsing?\r\n" +
                "Safe browsing simply means using the internet in a way that keeps you and your information safe. " +
                "Every time you open a web browser — Chrome, Safari, Edge, Firefox — and visit a website, you are making choices that affect your security. " +
                "Safe browsing is the set of habits that protect you from fake websites, malicious downloads, stolen passwords, and trackers that follow you around the internet. " +
                "Think of it like walking through a neighborhood. Some streets are safe. " +
                "Some have broken glass, strangers who bother you, or houses that look like one thing but are actually something dangerous. " +
                "Safe browsing is learning to tell the difference and knowing how to protect yourself no matter where you go online.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Safe Browsing on Your Phone\r\n" +
                "Your phone is a computer, and safe browsing applies there too. " +
                "Be careful what links you click in text messages and social media apps." +
                " Use the same habits: do not click unexpected links, check addresses carefully, and look for the padlock icon. " +
                "Be aware that phone screens are smaller, which makes it harder to see the full web address." +
                " You can often tap on the address bar to see the full address. Also be careful with QR codes." +
                " Scammers can put fake QR codes on parking meters, restaurant tables, and flyers. When you scan a QR code, it takes you to a website just like clicking a link." +
                " If you scan a QR code in a public place and it takes you to a website asking for payment or personal information, stop and think." +
                " Is this normal? Could this be fake?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What to Do If You Think You Visited a Bad Site\r\n" +
                "If you think you might have visited a fake website or clicked something dangerous, do not panic. First, close the browser tab immediately. " +
                "Do not click anything else on that page. If you entered any passwords, go to the real website (type the address yourself) and change those passwords right away." +
                " Run a virus scan on your device. If you entered credit card information, contact your bank and watch your statements closely." +
                " If you downloaded and opened a file, disconnect from the internet and run a full antivirus scan. Acting quickly can stop most damage before it gets serious.");

        }
        public void MobileSecurity()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What Is Mobile Security?\r\n" +
                "Mobile security means protecting your smartphone and tablet from threats, just like you protect your computer." +
                " Your phone is not just a phone. It is a computer that fits in your pocket, and it probably contains even more sensitive information than your laptop." +
                " Think about everything on your phone: your emails, text messages, photos, contacts, banking apps, social media, passwords," +
                " location history, and sometimes even your health data. Losing your phone or having it hacked can be a disaster." +
                " Mobile security is the set of habits and tools that keep your device, your data, and your accounts safe. " +
                "The good news is that protecting your phone is not hard. It just takes a few simple steps.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lock your phone with something stronger than a swipe. " +
                "Turn on automatic updates for your phone and your apps." +
                " Only download apps from official app stores." +
                " Be stingy with permissions — apps should only get what they actually need. Avoid public Wi-Fi for anything important, or use a VPN. " +
                "Turn off Bluetooth when you are not using it. Never click links in unexpected text messages. Set up remote tracking and wiping in case you lose your phone. " +
                "Back up your phone regularly. " +
                "That is it. Your phone is probably the most personal device you own. It goes everywhere with you. " +
                "It knows where you go, who you talk to, what you look at, and what matters to you. Protecting it is not hard. " +
                "Just build these habits, and you will keep your digital life safe even if your phone ends up in someone else's hands.");
        }
        public void exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("thank you for using safetybotAnetor");
            System.Environment.Exit(0);
            

        }
    }
}
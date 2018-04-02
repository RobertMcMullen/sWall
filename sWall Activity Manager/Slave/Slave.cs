using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Xml;

namespace sWall_Activity_Manager_Slave
{
    class Slave
    {
        // Shared drive
        private static string sharedActivitySetPath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Shared Drive\activitySet.xml";
        private static string sharedActivitiesDirectoryPath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Shared Drive\Activities";

        // Local machine
        private static string localActivitySetPath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Slave\activitySet.xml";
        private static string localActivitiesDirectoryPath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Slave\Activities";

        // HACK Confirm actual port
        private static int localPort = 69;

        static void Main(string[] args)
        {
            UdpClient client;
            XmlDocument localActivitySet;
            XmlDocument sharedActivitySet;

            XmlNodeList xnList;

            localActivitySet = new XmlDocument();

            sharedActivitySet = new XmlDocument();

            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, localPort);
            client = new UdpClient(localPort);

            // Flags indicating the presence of the activity on the shared drive and local machine
            bool activityOnShared;
            bool activityOnLocal;

            // Name of the activity that will be updated, sent by the master
            string activityName;

            Console.Title = "sWall Activity Manager Slave";

            // Always wait for updates from master
            while (true)
            {
                // Reset flags
                activityOnShared = false;
                activityOnLocal = false;

                // Wait for the activity name
                activityName = Encoding.ASCII.GetString(client.Receive(ref groupEP));

                // Reload the shared xml to accomodate update from master
                sharedActivitySet.Load(sharedActivitySetPath);
                // Determine if activity is on shared drive
                xnList = sharedActivitySet.SelectNodes("/Activities/Activity");
                foreach (XmlNode node in xnList)
                {
                    if (node["Name"].InnerText.Equals(activityName))
                    {
                        activityOnShared = true;
                        break;
                    }
                }

                // Reload local xml since it has been copied form the last update
                localActivitySet.Load(localActivitySetPath);
                // Determine if activity is on local machine
                xnList = localActivitySet.SelectNodes("/Activities/Activity");
                foreach (XmlNode node in xnList)
                {
                    if (node["Name"].InnerText.Equals(activityName))
                    {
                        activityOnLocal = true;
                        break;
                    }
                }

                // Copy XML from shared drive to local machine, overwrite old one
                File.Copy(sharedActivitySetPath, localActivitySetPath, true);

                // Add
                if (activityOnShared && !activityOnLocal)
                {
                    Console.WriteLine($"{DateTime.Now.ToString()} - Add activity {activityName}");
                    
                    // Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sharedActivitiesDirectoryPath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sharedActivitiesDirectoryPath, localActivitiesDirectoryPath));

                    // Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sharedActivitiesDirectoryPath, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sharedActivitiesDirectoryPath, localActivitiesDirectoryPath), true);
                }

                // Edit
                else if (activityOnShared && activityOnLocal)
                {
                    Console.WriteLine($"{DateTime.Now.ToString()} - Edit activity {activityName}");
                    
                    // Copy activity directory from shared drive to local machine
                    
                    // Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(sharedActivitiesDirectoryPath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(sharedActivitiesDirectoryPath, localActivitiesDirectoryPath));

                    // Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(sharedActivitiesDirectoryPath, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sharedActivitiesDirectoryPath, localActivitiesDirectoryPath), true);
                }

                // Delete
                else if (!activityOnShared && activityOnLocal)
                {
                    Console.WriteLine($"{DateTime.Now.ToString()} - Delete activity {activityName}");

                    // Delete activity directory from local machine
                    Directory.Delete(Path.Combine(localActivitiesDirectoryPath, activityName), true);
                }

                // Error
                // If activity is not on either the local maching or the shared drive, there is an error
                // Do nothing
            }
        }
    }
}

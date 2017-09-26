using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_7_zad_2
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        Room diningRoom;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;

        Outside garden;
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        void CreateObjects()
        {
            diningRoom = new Room("Jadalnia", "stół");
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi");
            garden = new Outside("ogród", false);
            backYard = new OutsideWithDoor("Podwórko za domem", true, "dębowe drzwi ze złotą klamką");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "szklane drzwi");

            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            garden.Exits = new Location[] { backYard, frontYard };
            backYard.Exits = new Location[] { garden, kitchen };
            frontYard.Exits = new Location[] { backYard, garden };

            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            livingRoom.DoorLocation = frontYard;

        }
        void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
            {
                goThroughTheDoor.Visible = true;
            }
            else
            {
                goThroughTheDoor.Visible = false;
            }
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor goThroughTheDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(goThroughTheDoor.DoorLocation);
        }
    }
}

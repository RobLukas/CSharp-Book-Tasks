using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondPart
{
    public partial class Form1 : Form
    {
        int Moves;

        Location currentLocation;
        Opponent opponent;

        Room diningRoom;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;

        OutsideWithHidingPlace driveway;
        OutsideWithHidingPlace garden;
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;

        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        void CreateObjects()
        {
            diningRoom = new Room("Jadalnia", "stół");
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką", "w szafie ściennej");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi", "w szafce");
            garden = new OutsideWithHidingPlace("ogród", false, "w szopie");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "ciężkie dębowe drzwi");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana poręcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obraz z psem", "w szafie ściennej");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            secondBedroom = new RoomWithHidingPlace("Mała sypialnia", "małe łóżko", "pod łóżkiem");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");

            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            livingRoom.Exits = new Location[] { diningRoom, hallway };
            kitchen.Exits = new Location[] { diningRoom };
            garden.Exits = new Location[] { backYard, frontYard };
            backYard.Exits = new Location[] { garden, kitchen };
            frontYard.Exits = new Location[] { backYard, garden };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { driveway, garden, backYard };
            backYard.Exits = new Location[] { driveway, garden, backYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            stairs.Exits = new Location[] { livingRoom, hallway };

            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            livingRoom.DoorLocation = frontYard;

        }
        void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mnie w " + Moves + " ruchach!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach! Ukrywał się w " + foundLocation.HidingPlaceName + ".";
            }

            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            exits.Visible = false;
            goThroughTheDoor.Visible = false;
            check.Visible = false;
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

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            Application.DoEvents();
            for (int i = 1; i < 11; i++)
            {
                description.Text = i + "...";
                opponent.Move();
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            description.Text = "Gotowy czy nie - nadchodzę!";

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
    }
}
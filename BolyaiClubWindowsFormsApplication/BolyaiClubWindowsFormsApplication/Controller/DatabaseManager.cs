﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BolyaiClubWindowsFormsApplication.Model;

namespace BolyaiClubWindowsFormsApplication.Controller
{
    public class DatabaseManager
    {
        public static void AddPerson(Person person)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public static void AddClient(Client client)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        internal static void AddRoom(Room room)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.Rooms.Add(room);
                context.SaveChanges();
            }
        }

        public static void AddUser(User user)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static User GetUser(string email, string password)
        {
            User selectedUser = null;
            using (var context = new BolyaiClubDbContext())
            {
                IEnumerable<Person> personResult = from p in context.People
                                                   where p.Email == email
                                                   select p;
                if (personResult.Count() == 1)
                {
                    Person selectedPerson = personResult.First();
                    IEnumerable<User> userResult = from u in context.Users
                                                   where u.PersonId == selectedPerson.PersonId && u.Password == password
                                                   select u;
                    if (userResult.Count() == 1)
                    {
                        selectedUser = userResult.First();
                    }
                }
            }
            return selectedUser;
        }

        public static Person GetPerson(int PersonId)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.People.Find(PersonId);
            }
        }

        public static string GetPersonEmail(int PersonId)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.People.Find(PersonId).Email;
            }
        }

        internal static User GetUser(int CreatedBy)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.Users.Find(CreatedBy);
            }
        }

        internal static Room GetRoom(int RoomId)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.Rooms.Find(RoomId);
            }
        }

        internal static Price GetPrice(int PriceId)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.Prices.Find(PriceId);
            }
        }

        internal static Client GetClient(int RenterId)
        {
            using (var context = new BolyaiClubDbContext())
            {
                return context.Clients.Find(RenterId);
            }
        }

        public static List<Client> GetClients()
        {
            List<Client> renters = new List<Client>();
            using (var context = new BolyaiClubDbContext())
            {
                IEnumerable<Client> renterResult = from r in context.Clients
                                                   select r;
                foreach (var renter in renterResult)
                {
                    renters.Add(renter);
                }
            }
            return renters;
        }

        internal static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var context = new BolyaiClubDbContext())
            {
                IEnumerable<User> userResult = from u in context.Users
                                               select u;
                foreach (var user in userResult)
                {
                    users.Add(user);
                }
            }
            return users;
        }

        internal static List<Room> GetRooms()
        {
            List<Room> rooms = new List<Room>();
            using (var context = new BolyaiClubDbContext())
            {
                IEnumerable<Room> roomResult = from r in context.Rooms
                                               select r;
                foreach (var room in roomResult)
                {
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        // Removes
        internal static void RemoveRenter(Client renter)
        {
            Person person = GetPerson(renter.PersonId);
            using (var context = new BolyaiClubDbContext())
            {
                context.Clients.Attach(renter);
                context.Clients.Remove(renter);
                context.SaveChanges();
            }
            RemovePerson(person);
        }

        public static void RemovePerson(Person person)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.People.Attach(person);
                context.People.Remove(person);
                context.SaveChanges();
            }
        }

        internal static void RemoveRoom(Room room)
        {
            using (var context = new BolyaiClubDbContext())
            {
                context.Rooms.Attach(room);
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
        }

        public static bool IsUniqEmail(string email)
        {
            using (var context = new BolyaiClubDbContext())
            {
                IEnumerable<Person> personResult = from p in context.People
                                                   where p.Email == email
                                                   select p;
                if (personResult.Count() == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

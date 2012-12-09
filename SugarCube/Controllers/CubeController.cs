using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SugarCube.Models;

namespace SugarCube.Controllers
{
    public class CubeController : Controller
    {
        //
        // GET: /Cube/

        private void Initialize(out List<JournalEntry> cubes, out  SelectListItem[] tags, out  SelectListItem[] permissions)
        {
            cubes = new List<JournalEntry>(){
                new JournalEntry{ Title = "Hello World 1", Date=DateTime.Today, Text = "This is a short message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 2", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="other" },
                new JournalEntry{ Title = "Hello World 3", Date=DateTime.Today, Text = "This is a message with an image.", Image = "~/Content/Images/7.jpg", Type="journal"},
                new JournalEntry{ Title = "Hello World 4", Date=DateTime.Today, Image = "~/Content/Images/4.jpg", Type="journal" },
                new JournalEntry{ Title = "Hello World 5", Date=DateTime.Today, Text = "This is a short message.", Type="other" },
                new JournalEntry{ Title = "Hello World 6", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 7", Date=DateTime.Today, Image = "~/Content/Images/6.jpg", Type="journal" },
                new JournalEntry{ Title = "Hello World 8", Date=DateTime.Today, Text = "This is a short message.", Type="other" },
                new JournalEntry{ Title = "Hello World 9", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 10", Date=DateTime.Today, Text = "This is a short message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 11", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="other" },
                new JournalEntry{ Title = "Hello World 12", Date=DateTime.Today, Text = "This is a message with an image.", Image = "~/Content/Images/3.jpg", Type="journal"},
                new JournalEntry{ Title = "Hello World 13", Date=DateTime.Today, Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed a dapibus lorem. Etiam vel enim vel justo aliquet tempus quis id orci. In ultricies, purus vel adipiscing cursus, nulla nunc luctus ligula, eu faucibus est velit ornare leo. Suspendisse vehicula purus eu nisi mattis vestibulum. Nulla facilisi. Mauris imperdiet aliquet urna, eget gravida dolor lacinia eu. Pellentesque sodales consectetur ante vel consequat. Proin fringilla consectetur dui, sit amet lobortis nulla placerat sodales. Aliquam a facilisis neque. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Suspendisse ac leo nec eros malesuada ultricies sed at ipsum.

Fusce sit amet purus et mauris congue mattis sed ut arcu. Praesent faucibus libero sed nulla imperdiet sagittis. Aenean ac magna in risus ullamcorper pulvinar at ut nulla. Phasellus volutpat risus id leo pretium eget venenatis nibh dapibus. Morbi eget dolor dolor. Suspendisse potenti. Aenean vitae diam at purus mattis suscipit sit amet a nibh. Phasellus condimentum rutrum iaculis. Suspendisse accumsan, velit luctus congue condimentum, libero magna pretium sapien, ac semper mi est quis arcu. Duis ultricies lectus id metus pulvinar et consectetur mauris lobortis. Suspendisse purus turpis, condimentum sed commodo sed, vestibulum et velit. Praesent in neque neque. Etiam ullamcorper aliquam nisl a varius. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.

Vivamus feugiat rhoncus arcu, eu molestie felis tristique vel. Proin congue lobortis elit eu porttitor. Praesent magna ante, placerat nec elementum at, pretium ac lacus. Aliquam lacus est, fermentum quis feugiat eget, rutrum id mi. Morbi placerat nibh a nulla congue consequat. Morbi elementum metus sit amet mauris sodales nec pharetra magna cursus. Praesent egestas dolor et diam dapibus cursus vulputate eros pharetra. Donec adipiscing lectus sed odio ultricies tristique. Duis ac tortor nulla. Mauris elementum lorem sit amet est molestie elementum.

Quisque sit amet libero non diam sodales lacinia a a mauris. Nam sit amet velit magna, at feugiat lectus. Morbi tellus neque, lacinia vel rutrum vitae, feugiat sit amet turpis. Mauris varius, lorem at ultrices eleifend, sem enim convallis nulla, at fermentum leo odio ut neque. Duis et nisi leo, eget euismod ipsum. Etiam viverra suscipit urna nec placerat. Quisque viverra gravida vulputate. Nullam posuere volutpat convallis. Nullam dapibus consequat ornare. Morbi eros ante, fringilla ut scelerisque at, molestie non felis.

In hac habitasse platea dictumst. Praesent ut massa ut odio facilisis lobortis. Suspendisse odio mi, adipiscing id lobortis at, varius vel eros. Nullam scelerisque lobortis dolor sit amet commodo. Duis et dui turpis, vel luctus ante. Donec in hendrerit lacus. Phasellus ut mauris ac nisl mollis iaculis ut ultricies arcu. Cras rhoncus neque ac augue iaculis dictum.", Image = "~/Content/Images/4.jpg", Type="journal"},
                new JournalEntry{ Title = "Hello World 14", Date=DateTime.Today, Text = "Sed elit leo, fringilla at varius at, iaculis vitae felis. Nunc pulvinar enim ac augue suscipit accumsan. Vestibulum ullamcorper euismod sagittis. Pellentesque risus purus, auctor eget dignissim ac, rutrum sit amet nunc. Fusce vehicula arcu vitae quam luctus tincidunt. Nullam ac orci interdum eros tempor ullamcorper eu vitae metus. Aliquam non enim ut purus rhoncus tempus.", Image = "~/Content/Images/2.jpg", Type="journal"}
            };

            permissions = new SelectListItem[] {
                new SelectListItem{ Text = "friends & strangers", Value = "5"},
                new SelectListItem{ Text = "maybe friends", Value = "4"},
                new SelectListItem{ Text = "just friends", Value = "3"},
                new SelectListItem{ Text = "dear best friends", Value = "2" },
                new SelectListItem{ Text = "my eyes only", Value = "1" },
                new SelectListItem{ Text = "friends & strangers", Value = "5"},
                new SelectListItem{ Text = "maybe friends", Value = "4"},
                new SelectListItem{ Text = "just friends", Value = "3"},
                new SelectListItem{ Text = "dear best friends", Value = "2" },
                new SelectListItem{ Text = "my eyes only", Value = "1" }
            };


            Random rand = new Random();
            var tagsList = new List<SelectListItem>();
            for (int i = 1; i <= 30; i++)
            {
                switch (rand.Next(1, 3))
                {
                    case 1:
                        tagsList.Add(new SelectListItem { Text = "cat " + i, Value = i.ToString() });
                        break;
                    case 2:
                        tagsList.Add(new SelectListItem { Text = "calvin & hobbes " + i, Value = i.ToString() });
                        break;
                    case 3:
                        tagsList.Add(new SelectListItem { Text = "elephant " + i, Value = i.ToString() });
                        break;
                }
            };

            tags = tagsList.ToArray();
        }

        public ActionResult Index()
        {
            List<JournalEntry> cubes;
            SelectListItem[] tags;
            SelectListItem[] permissions;
            Initialize(out cubes, out tags, out permissions);
            return View(new CubeViewModel() { JournalEntries = cubes, Tags = tags, Permissions = permissions });
        }

        public ActionResult GetCubes()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CreateJournal(FormCollection form)
        {
            List<JournalEntry> cubes;
            SelectListItem[] tags;
            SelectListItem[] permissions;
            Initialize(out cubes, out tags, out permissions);
            return View("Index", new CubeViewModel() { JournalEntries = cubes, Tags = tags, Permissions = permissions });
        }

        public ActionResult CubeTest()
        {
            return View();
        }

        public ActionResult Journal()
        {
            JournalEntry viewModel = new JournalEntry
            {
                Author = new User { Id = 1, Name = "silverangel" },
                Date = DateTime.Today,
                Text = "<p>Lorem ipsum dolor sit amet,<br/><br/> consectetur adipiscing elit. Duis semper lorem sit amet sapien egestas tincidunt. Nam sed nulla vitae massa rutrum tristique ac at dolor. Fusce aliquet sapien eu metus tempus eu vulputate nisl cursus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nam consequat dui vitae felis lacinia vel elementum tellus vulputate. Nam justo leo, sagittis sed laoreet at, congue eget urna. Phasellus vulputate diam in velit volutpat sed congue quam tempus. Aliquam erat volutpat. Proin auctor tempor varius. Nulla iaculis velit in ligula tincidunt volutpat. Praesent at nunc sed mauris fermentum aliquet.<br/><br/> <strong>What can I do? Should I keep waiting or move on?</strong></p>",
                Title = "Should I Text Him?",
                Type = "journal",
                Comments = new Comment[] {
                    new Comment
                    {
                        Text="I am so sorry to hear that!",
                        Author = new User{ Name="purplepig", Gender= GenderType.Female},
                        Timestamp = DateTime.Today, 
                        Comments = new Comment[]
                        {
                       
                            new Comment
                            {
                                Text="hahaha girls are silly",
                                Author =new User{Name="meanboy", Gender= GenderType.Male},
                                Timestamp = DateTime.Today,
                                Comments = new Comment[]
                                {
                                    new Comment
                                    {
                                        Text="Boys are",
                                        Author = new User{ Name="meangirl", Gender= GenderType.Female},
                                        Timestamp = DateTime.Today
                                    }
                                }
                            },
                     
                            new Comment
                            {
                                Text = "blah",
                                Author = new User{Name="girl", Gender= GenderType.Female},
                                Timestamp = DateTime.Today
                            }  
                        }
                    }
                }
            };
            return View(viewModel);
        }
    }
}

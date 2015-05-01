namespace KotareParable.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KotareParable.KotareParableDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KotareParable.KotareParableDBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Narrations.AddOrUpdate(
                n => n.Statement,
                new Narration
                {
                    Statement =
                        "You wake up in a dark room. You're not sure how you got here, but you need to escape. Upon trying the door, you find it unlocked and you walk out. The hallway outside goes left and right. Which way will you go?"
                },
                new Narration
                {
                    Statement =
                        "You come to a lift and decide to take a ride. You go to press the button for up or down."
                },
                new Narration
                {
                    Statement =
                        "You continue down the hall for what feels like ages. Soon you come to a hole in the wall to your left. You can crawl into the hole or continue down the seemingly endless hall."
                },
                new Narration
                {
                    Statement =
                        "You come to a cobweb-filed, attic. You look around and amongst the clutter and you find a box that looks as though it was recently added. On the other side of the room is a window. You begin to approach one."
                },
                new Narration
                {
                    Statement =
                        "You come to a damp and musty basement. You see both a cat and a rat and know that one will lead you to your freedom, and the other to your death. You begin to approach one."
                }
                //new Narration { Statement = "You continue down the hall for what feels like ages. Soon you come to a hole in the wall to your left. You can crawl into the hole or continue down the seemingly endless hall." }
                //new Narration { Statement = "You continue down the hall for what feels like ages. Soon you come to a hole in the wall to your left. You can crawl into the hole or continue down the seemingly endless hall." }
                //new Narration { Statement = "You continue down the hall for what feels like ages. Soon you come to a hole in the wall to your left. You can crawl into the hole or continue down the seemingly endless hall." }
                //new Narration { Statement = "You continue down the hall for what feels like ages. Soon you come to a hole in the wall to your left. You can crawl into the hole or continue down the seemingly endless hall." }
                );
            
            context.Responses.AddOrUpdate(
                r => r.Statement,
                new Response { Statement = "Left", NarrationId = 2},
                new Response { Statement = "Right", NarrationId = 3},
                new Response { Statement = "Up", NarrationId = 4},
                new Response { Statement = "Down", NarrationId = 5},
                new Response { Statement = "Box", NarrationId = 6},
                new Response { Statement = "Window", NarrationId = 7},
                new Response { Statement = "Cat", NarrationId = 8},
                new Response { Statement = "Rat", NarrationId = 9},
                new Response { Statement = "Continue", NarrationId = 10},
                new Response { Statement = "Hole", NarrationId = 11},
                new Response { Statement = "GoThrough", NarrationId = 12},
                new Response { Statement = "TurnAround", NarrationId = 13},
                new Response { Statement = "Check", NarrationId = 14},
                new Response { Statement = "Run", NarrationId = 15}
            );
        }
    }
}

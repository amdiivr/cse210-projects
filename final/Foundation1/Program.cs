using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Foundation1 World!");

        Console.WriteLine("\n\n__________________________First Video__________________________");
        Video firstVideo = new Video();
        firstVideo.title = "Dogs running";
        firstVideo.author = "Andy Vasquez";
        firstVideo.length = 30;
        Comments userComment1 = new Comments();
        userComment1.nameUser = "Antonella";
        userComment1.firstComment = "This video es very funny.";
        userComment1.secondComment = "I hope the dogs are good.";
        userComment1.thirdComment = "We need more videos for the dogs life.\n\n__________________________Second Video__________________________";
        firstVideo.infoComments.Add(userComment1);

        Video secondVideo = new Video();
        secondVideo.title = "Cats Playing";
        secondVideo.author = "Antonella Hidalgo";
        secondVideo.length = 20;
        Comments userComment2 = new Comments();
        userComment2.nameUser = "Pedro";
        userComment2.firstComment = "I hope the cats are okay.";
        userComment2.secondComment = "Seeing cats playing relaxes me.";
        userComment2.thirdComment = "Growing cats can be more hyperactive.\n\n__________________________Third Video__________________________";
        secondVideo.infoComments.Add(userComment2);

        Video thirdVideo = new Video();
        thirdVideo.title = "Fish swimming";
        thirdVideo.author = "Ramiro Yupanqui";
        thirdVideo.length = 40;
        Comments userComment3 = new Comments();
        userComment3.nameUser = "Andy";
        userComment3.firstComment = "Each type of fish has a different way of swimming.";
        userComment3.secondComment = "The fish create a unique swimming pattern.";
        userComment3.thirdComment = "In the end they are consumed by us so it is always good to see them swim.";
        thirdVideo.infoComments.Add(userComment3);

        Tracking generalInfo = new Tracking();
        generalInfo.numberVideo = "Total Info";
        
        generalInfo.infoVideo.Add(firstVideo);
        generalInfo.infoVideo.Add(secondVideo);
        generalInfo.infoVideo.Add(thirdVideo);

        generalInfo.DisplayTotalInfo();

    }
}
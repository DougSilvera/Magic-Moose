using System;

    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("Ask a question to hear your fortune from the moose of destiny");
    Console.WriteLine();
    peerIntoTheMooseSoul();
    
    



int randomInt() {
      Random r = new Random();
      int genRand= r.Next(0,20);
      return genRand;
   }


void peerIntoTheMooseSoul()
{
    string[] responses = {
            "As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
"Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
"Yes.",
"Yes – definitely.",
"You may rely on it.",
"not important, russia will nuke us all anyway!"
        };
    Console.Write("Ask Swami Moose a Question!: ");
    string answer = Console.ReadLine();
    if (answer != "") {
       MooseSays(responses[randomInt()]);
    } else {
        System.Environment.Exit(0);
    }
    
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}



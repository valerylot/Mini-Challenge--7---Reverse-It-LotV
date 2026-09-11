//Valery Lot
//09/11/2026
//Mini Challenge #7 Reverse It
//We used a for loop to reverse a number sequence by decrementing it. Then we used a while loop if the user wanted to play the game again.
//Peer Review Name:
//Review:

Console.Clear();

string playAgain;

do
{
Console.WriteLine("Please enter a number sequence.");
string number = Console.ReadLine();

Console.WriteLine($"Your number sequence is: {number}");

//for loop
string numberReverse = "";

for(int i = number.Length; i > 0; i--)
{
    numberReverse += number[i-1];
}
Console.WriteLine($"Your number sequence in reverse is: {numberReverse}");


//play again loop
Console.WriteLine("Do you want to play again? Y / N ");
playAgain = Console.ReadLine().ToUpper();

while (playAgain != "Y" && playAgain != "N")
    {
        Console.WriteLine("Invalid input. Please enter Y / N ");
        playAgain = Console.ReadLine().ToUpper();
    }

} while(playAgain == "Y");
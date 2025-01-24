using System;
class SimpleDiceGame {
    static void Main() {
        int playerRandomNumber;
        int enemyRandomNumber;
        int playerPoints = 0;
        int enemyPoints = 0;
        
        Random random = new Random();
        
        for(int i = 0; i < 10; i++) {
            Console.WriteLine("Press any key to roll the dice.");
            
            Console.ReadKey();
            
            playerRandomNumber = random.Next(1, 7);
            Console.WriteLine("You rolled a " + playerRandomNumber);
            
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            
            enemyRandomNumber = random.Next(1, 7);
            Console.WriteLine("Enemy AI rolled a " + enemyRandomNumber);
            
            if(playerRandomNumber > enemyRandomNumber) {
                playerPoints++;
                Console.WriteLine("Player wins this round!");
            } else if(playerRandomNumber < enemyRandomNumber) {
                enemyPoints++;
                Console.WriteLine("Enemy wins this round!");
            } else {
                Console.WriteLine("Draw!");
            }
            
            Console.WriteLine("Score - Player: " + playerPoints + " / Enemy: " + enemyPoints);
        }
        
        if(playerPoints > enemyPoints) {
            Console.WriteLine("You win!");
        } else if(playerPoints < enemyPoints) {
            Console.WriteLine("You lose!");
        } else {
            Console.WriteLine("It's a draw!");
        }
        
        Console.ReadKey();
    }
}

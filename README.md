# NFL Coaches Draft Program (Project 1)

The NFL would like for you to create an application that allows the head coach to input up to 5 draft prospects.  A coach can pick any combination of players, but cannot exceed 95 million dollars.  Listed below is a chart that depicts the top 40 players along with their negotiated salaries which does not include their signing bonus.

Construct a program that allows a coach to continuously enter their round of picks until they are ready to stop using the program.  With each iteration of picks, you will need to let the coach know the names of the players, the positions, the institution, the individual player’s salaries, the cumulative salary of all players selected, and the remaining amount left over to pay-out signing bonuses (95 million minus total sum of player salaries).  If a player is picked, include logic that would not allow the coach/end-user to not select the same player during the coaches iteration of picks.  In addition, if a coach selects any three players within the best, second best, third best, and stay under 65 million dollars, output a message that states “Cost Effective”.  

## Requirements

Create using .NET Core Console Application

The Program should make use of Object Oriented Principles discussed in class and utilize at least one class structure



## Additional Challenge 2-Points of Extra Credit

Install Newtonsoft.JSON (author: James Newton-King) via NuGet Package manager and feed in the player information from a JSON file. Serialize each player as an c# Object an begin to use the data in your program.  (https://www.newtonsoft.com/json (Links to an external site.)Links to an external site.)
* The above implementation requires that you know a little about how to work with JSON data.

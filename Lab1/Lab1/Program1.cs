using System.ComponentModel.Design;

const int requiredAge = 14;
const int beerRequiredAge = 18;
const int simRequiredAge = 18;
const string accessDeniedMessage = "You must be at least 16 years old.";
const string accessAllowedMessage = "Welcome to my shop.";
const string beerRestrictionMessage = "You must be 18 years old to buy a beer.";
const string simRestrictionMessage = "You must be 18 years old to register a SIM Card.";

int age = 16;

if (age >= beerRequiredAge && age >=simRequiredAge)
{
    Console.WriteLine(accessAllowedMessage);
}
else if (age >= requiredAge)
{
    Console.WriteLine($"{accessAllowedMessage} {beerRestrictionMessage} {simRestrictionMessage}");
}
else
{
    Console.WriteLine(accessDeniedMessage);
}

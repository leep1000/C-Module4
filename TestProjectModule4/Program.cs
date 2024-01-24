/*
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"First roll: {roll2}");
Console.WriteLine($"First roll: {roll3}");


dice.Next();

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(secondValue, firstValue);

Console.WriteLine(largerValue);

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

roll1 = 2;
roll2 = 1;
roll3 = 1;

int total = roll1 + roll2 + roll3; 

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{ 
    if ((roll1 == roll2) && (roll2 == roll3))
    {
    total += 6;
    Console.WriteLine($"You rolled triples! +6 bonus to total! New total: {total}");
    }
    else
    {
        total += 2;
        Console.WriteLine($"You rolled doubles! +2 bonus to total! New total: {total}");
    }
}


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
} 
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total >= 7)
{
    Console.WriteLine("You win a new trip!");
}
else
{
  Console.WriteLine("You win a kitten!");  
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
daysUntilExpiration = 5;
int discountPercentage = 0;

if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired."); 
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine($"Your subscription expires within a day!");
        discountPercentage = 20;
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!");
        discountPercentage = 10;
    }
    else if (daysUntilExpiration <= 10)
    {
        Console.WriteLine($"Your subscription will expire soon. Renew now!");
    }

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

Console.WriteLine($"Product: {size} {color} {type}");
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

string[] fraudulentOrderIDs = {"A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
string[] OrderIDsWithB = {};

foreach (string ID in orderIDs)
{
    if(ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}

string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i=0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// The high-level purpose of this code is to reverse a string and count the number of times a particular character appears.
// Then prints the results

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] reverseMessage = originalMessage.ToCharArray();
Array.Reverse(reverseMessage);

int count = 0;

foreach (char letter in reverseMessage) 
{ 
    if (letter == 'o') 
    { 
        count++; 
    } 
}

string newMessage = new String(reverseMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");

Console.WriteLine("a" == "a"); // true
Console.WriteLine("a" == "A"); // false
Console.WriteLine(1 == 2); // false

string myValue = "a";
Console.WriteLine(myValue == "a"); // true

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


Console.WriteLine("a" != "a"); // false
Console.WriteLine("a" != "A"); // true
Console.WriteLine(1 != 2); // true

string myValue = "a";
Console.WriteLine(myValue != "a"); // false

Console.WriteLine(1 > 2); // false
Console.WriteLine(1 < 2); // true
Console.WriteLine(1 >= 1); // true
Console.WriteLine(1 <= 1); // true

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // true 
Console.WriteLine(pangram.Contains("cow")); // false

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("lol"));

int saleAmount = 999;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

Random coin = new Random();
int coinFlip = coin.Next(1, 3);
Console.WriteLine((coinFlip == 1) ? "heads" : "tails");

string permission = "Manager";
int level = 15;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges, Mr Manager.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Inside of code block: {value}");


bool flag = true;
if (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");



int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

string fruit = "apple";



switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for {fruit}");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry");
        break;
}


int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
    {
        break;
    }
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

// FizzBuzz Challenge

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8)
    {
        continue;
    }

    Console.WriteLine(current);
} while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

Random dice = new Random();

int heroHP = 10;
int enemyHP = 10;

bool isHeroTurn = true;

while (heroHP > 0 && enemyHP > 0)
{
    int attack = dice.Next(1, 7);

    if (isHeroTurn)
    {
        enemyHP -= attack;
        Console.WriteLine($"Enemy was damaged and lost {attack} health and now has {enemyHP} health.");
        // isHeroTurn = false;
    }
    else
    {
        heroHP -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health.");
        // isHeroTurn = true;
    }

    // Console.WriteLine($"{(isHeroTurn ? "Enemy" : "Hero")} was damaged and lost {attack} health and now has {(isHeroTurn ? enemyHP : heroHP)}.");
    isHeroTurn = !isHeroTurn;
}

string winner = heroHP > 0 ? "Hero" : "Enemy";
Console.WriteLine($"{winner} wins!");

// Code Project 1
string? readResult;
bool validNumber = false;
int numericValue = 0;

Console.WriteLine("Enter a number between 5 and 10");

do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (validNumber == false)
    {
        Console.WriteLine("That's not a number. Please enter a number between 5 and 10.");
    }
    else if (numericValue < 5 || numericValue > 10)
    {
        Console.WriteLine("Your number is not between 5 and 10. Please enter a number between 5 and 10");
        validNumber = false;
    }

} while (validNumber == false);

Console.WriteLine($"Well done! Your number ({numericValue}) has been accepted.");

// Code Project 2

string[] roles = new string[] { "administrator", "manager", "user" };
bool isValidUser = false;
string userRole = "";
string? readResult;
string userInput = "";

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

while (!isValidUser)
{
    readResult = Console.ReadLine();
    userInput = readResult;

    if (readResult != null)
    {
        userRole = readResult.Trim();
    }

    foreach (string role in roles)
    {
        if (role == userRole.ToLower())
        {
            userRole = role;
            isValidUser = true;
            break;
        }
    }

    if (isValidUser == false)
    {
        Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
}

Console.WriteLine($"Your input value ({userInput}) has been accepted.");

// Code Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{

    string myString = myStrings[i];
    int periodLocation = myString.IndexOf(".");

    while (periodLocation != -1)
    {

        string sentence = myString.Remove(periodLocation);
        Console.WriteLine(sentence);
        myString = myString.Substring(periodLocation + 1).TrimStart();

        periodLocation = myString.IndexOf(".");

    }

    Console.WriteLine(myString);
}

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte    : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// null reference - no memory address yet
int[] data;

// new instance create a memory address
data = new int[3];

// Alternative way to write the above
int[] data = new int[3];

// String is a special case; we don't need the new operator to declare a new string
string shortenedString = "Hello World";
Console.WriteLine(shortenedString);
*/

// Is it possible that attempting to change the value's data type would throw an exception at run time?

/*
// Doesn't work as we can't implicitly convert type 'string' to 'int' because compilers make safe conversions
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

/*
// This produces '24', so we can implicitely convert 'int' to 'string'
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");
// int: 3

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
// decimal: 3

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");
// decimal: 3.14

decimal myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
// int: 3

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
//Decimal: 1.23456789
Console.WriteLine($"Float: {myFloat}");
// Float: 1.2345679


int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
// 57

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
// 12


string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) + Convert.ToInt32(value2);
Console.WriteLine(result);
// 12

int value = (int)1.5m; // casting truncates (aka ignores after .)
Console.WriteLine(value); // 1

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2); // 2

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Prints:
// -- A11
// -- A13
// -- B12
// -- B14 

// Reverse()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    // -- A13
    // -- B12
    // -- A11
    // -- B14
}


// Array.Clear()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}"); // Before: B14
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}"); // Error

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    // 
    // 
    // -- A11
    // -- B14
}

// Array.Resize()
using System.Numerics;

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}"); // Before: B14
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}"); // Error

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    // 
    // 
    // -- A11
    // -- B14
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"");

pallets[4] = "C01";
pallets[5] = "C02";
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    // --
    // --
    // -- B12
    // -- A13
    // -- C01
    // -- C02
}

// Remove elements with Array.Resize()
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}"); // count: 3

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    // 
    // 
    // -- B12
}

// Conditional Formatting
string first = "Hello";
string second = "World";
//string result = string.Format("{0} {1}!", first, second);
//Console.WriteLine(result); // "Hello World"

Console.WriteLine("{1} {0}!", first, second); // "World Hello"
Console.WriteLine("{0} {0} {0}", first, second); // "Hello Hello Hello"


string first = "Hello";
string second = "World";

Console.WriteLine($"{first} {second}");
// "Hello World"
Console.WriteLine($"{second} {first}");
// "World Hello"
Console.WriteLine($"{first} {first} {first}");
// "Hello Hello Hello"

decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Price: £123.45 (Save £50.00)

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// 123,456.79 units
Console.WriteLine($"Measurement: {measurement:N4} units");
// Measurement: 123,456.7891 units

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
// Tax rate: 36.79%

*/

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
// You saved £7.56 off the regular £67.55 price. 

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);
// You saved £7.56 off the regular £67.55 price. A discount of 11.19%!


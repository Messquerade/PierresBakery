# Pierre's Bakery

#### This console application will take an order for a fictional bakery from the user and display the cost of that order.

#### By Anna Clarke

## Technologies Used

* _C#_
* _.Net_
* _MSTest_

## Description

This console app will welcome the user to Pierre's Bakery and display the cost and deals for bread and pastries. It will accept an input of number of bread loaves and pastries from the user, calculate the cost of the user's order, and display that cost to the user.

## Installation Requirements

* Clone this repository to your desktop
* Open in text editor
* Make sure you have .Net version 5.0 installed
* In your terminal, run $ dotnet restore, to build obj and bin folders

## Testing

* To test, navigate into Bakery.Solution/Bakery.Tests/
* run $ dotnet test

## Setup

* Navigate into Bakery.Solution/Bakery/
* run command $ dotnet build
* run command $ dotnet run
* follow console instructions to use application

## Known Bugs

* _Orders of over 100 total baked goods are accepted instead of directed to bakery's email_

## License

_[MIT](https://opensource.org/licenses/MIT)_

Copywrite(c)2021 Anna Clarke

## Contact Information

Anna Clarke: anclarkie@gmail.com

# Specs

### Products

A parent class that holds Bread and Pastry as child classes? Abstract class? Uses the methods inside Bread and Pastry to add their costs and determine the cost of the entire order

### Bread

Constructor builds with a property of number of loaves. (Extend to include different kinds of bread: sourdough, honey wheat, potato buttermilk)

Bread constructor (input)
input is an integer, number of loaves (integer is a positive number, no larger than 100.
You don't want customers putting in a massive order without making sure the bakery can produce that amount.
Any orders over 100 should display an email for the bakery so the customer can contact the bakery and arrange an extra large order.
Depending on the size of the bakery, number of employees, number of orders etc. this upper limit will be higher or lower)  
input saved as a TotalLoaves property

method GetBreadCost()
called on Bread object to access TotalLoaves
output is an integer, cost of bread order  
To calculate the cost of the bread order, every 3rd loaf of bread is free  
One bread loaf costs $5.00

#### Inputs/Outputs

1. input = 0
   expected output = 0

2. input = 10
   expected output = 35

3. input = 11
   expected output = 40

4. input = 12
   expected output = 40

### Pastry

Same as Bread, except the deal is different: Buy 1 pastry for $2.00, or 3 for $5.00
In other words, every 3rd pastry is half off

#### Inputs/Outputs

1. input = 0
   expected output = 0

2. input = 4
   expected output = 7

3. input = 5
   expected output = 9

4. input = 6
   expected output = 10

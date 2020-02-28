# PIERRE'S BAKERY (C# Console Application)

### An console-based application to simulate interaction between a customer and a small bakery, hosted on [GitHub](https://github.com/KristaRutz/Pierre-s-Bakery-ConsoleApp/), where a user can view and buy baked goods.


### By **Krista Rutz**. _Last updated February 28, 2020._

## Description

This C# application allows the user to "enter" the bakery and utilizes the user's console-based inputs to display the menu items for the day, see special deals, create a grocery bag of Bread or Pastry items to purchase, and affect the inventory of the Bakery when they check out.

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

* Download or clone this repo.
  * **To Download ZIP:**
    * Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/Pierre-s-Bakery-ConsoleApp.git) site 
    * Once downloaded, open the ZIP and extract files. The new folder will be created as 'Pierre-s-Bakery-ConsoleApp'.
  * **To Clone:**
    * Clone from command line into your Desktop: ```$ git clone https://github.com/KristaRutz/Pierre-s-Bakery-ConsoleApp.git```
    * The new directory will be created as 'Desktop/Pierre-s-Bakery-ConsoleApp'.
* Once you have stored the files locally, execute the following commands. 
  * Navigate to the application directory: ```$ cd Pierre-s-Bakery-ConsoleApp```
  * ```dotnet build```
  * ```dotnet run```
* Upon success, the program will begin running in your console.

## Technologies Used

* **C#**
* **.NET Core 2.2**

## Specifications
<!-- <details> -->
  <summary>Expand specs for this project</summary>

| Spec | Example Input | Expected Output |
| :-------------     | :------------- | :------------- |
| User can quit the application | 'x' | "Goodbye" > Exited |
| User can continue on to see the specials and take actions | '1' | "Today's specials...make a selection!" |
| User can select how many loaves of bread to buy | '3'| "You have added 3 loaves of bread to your purchase" |
| User can select how many pastries to buy | '2'| "You have added 2 pastries to your purchase" |
| Adding bread or pastries will change the user's subtotal | "Buy 2 pastries" | Subtotal: $4 |
| User can view the total cost of the purchase | "view subtotal" | Your order costs $14 |
| Pierre's deals will be applied: B2GO bread, 3 for $5 pastries. | "Buy 3 pastries" | Subtotal: $5 |
| User can remove bread or pastries from their order | Remove 1 pastry | Subtotal: $4, Pastries: 2 |

</details>

## Known Bugs

No known bugs.

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns.  I can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

## Usage and Licensing

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Krista Rutz_**

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
</details>

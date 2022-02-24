# DIO_RPG_ObjectOriented
Objetive: Simulate RPG characters in a simple console application, to implement the object-oriented concepts in C#.
This is a challenge proposed by [DIO](https://www.dio.me/) in one of their C#/.NET courses.

## Specific objectives
- Represent RPG characters in a console application
- Characters should be implemented as objects
- Different character types should inherit from a generic Hero class (parent class)
- The child classes can override the parent methods as needed

## Implementation
- The player is presented with a main menu that let's them create a new hero, list the current heroes or simulate a fight.
- A "Player Interface" class was created to handle the menu outputs and inputs.
- An abstract Hero class was created with the basic methods and properties for all heroes.
- Four child classes were created to implement different hero types.
- Each hero type inherit the abilities of the Hero class (attack and defend) and contain a unique Special Ability.
- HP and MP are also specific to the hero types.

| Hero type | Regular Attack | Special Ability |
| ----- | ----- | ----- |
| Knight | Attack with a sword | **Power Attack**: Regular attack with a chance of critial hit based on a random number from 1 to 6 |
| Ninja | Attack with a sword | **Smoke Screen**: Produces a smoke screen that prevents the hero from being attacked |
| Black Wizard | Cast a magic attack | **Fire ball**: Casts a fire ball to attack the opponent |
| White Wizard | Cast a magic attack | **Cure**: Casts a cure spell to heal an ally |



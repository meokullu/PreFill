# PreFill

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

## Description

PreFill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right. Supported data types: (sbyte, byte, int, uint, long, ulong)

PreFill is optimized for cpu-intense applications.

## Listed Methods

```
* PreFilledCustom(long number, byte maxNumberOfDigit, string text = " ")
* PreFilledCustom(long number, byte maxNumberOfDigit, char text = ' ')
* PreFilledCustom(List<long> numberList, string text = " ")
* PrefilledCustom(List<long> numberList, char text = ' ')
```
Returns prefilled value

###

long number: Signed long numerical value.
byte maxNumberOfDigit: Maximum number of digit of numerical value.
string/char text: Desired value to add at left side.

###

List<long> numberList: List of signed long numberical values.
string/char text: Desired value to add at left side.

```
* PreFillCustom()
```

```
* PreFill[1-8]()
```

## Example Usage

###
 PrefilledCustom(5, 4, '0') = "0005"
 PrefilledCustom(55, 3, ' ') = "  55"

## Version History

* 1.0.0 Initial Release
  * See [commit change](https://github.com/meokullu/PreFill/commits/master) or See [release history](https://github.com/meokullu/PreFill/releases)
  * See CHANGELOG.md

## Licence
No licence is required.

## Authors
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

## Help
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

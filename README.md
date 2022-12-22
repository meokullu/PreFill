# PreFill

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

## Description

PreFill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right. Supported data types: (sbyte, byte, int, uint, long, ulong)

PreFill is optimized for cpu-intense applications.

## Listed Methods

```
* PreFilledCustom(long number, byte maxNumberOfDigit, string text = " ")
* PreFilledCustom(long number, byte maxNumberOfDigit, char text = ' ')
```

Returns prefilled value. (string)

* long number: Signed long numerical value.

* byte maxNumberOfDigit: Maximum number of digit of numerical value.

* string/char text: Desired value to add at left side.

```
* PreFilledCustom(List<long> numberList, string text = " ")
* PrefilledCustom(List<long> numberList, char text = ' ')
```

Returns prefilled values. (List<string>)

* List<long> numberList: List of signed long numberical values.
 
* string/char text: Desired value to add at left side.

```
* PreFillCustom(long number, int maxNumberOfDigit, string text = " ")
* PreFillCustom(long number, int maxNumberOfDigit, char text = ' ')
* PreFillCustom(ulong number, int maxNumberOfDigit, string text = " ")
* PreFillCustom(ulong number, int maxNumberOfDigit, char text = ' ')
```

Returns **prefill value only**. (string)

* ulong/long number: Signed or unsigned long numberical value.

* int maxNumberOfDigit: Maximum number of digit of numerical value.

* string/char text: Desired value to add at left side.

```
* PreFill[1-8](long number, char text = ' ')
* PreFill[1-8](ulong number, char text = ' ')
```

Returns ** prefill value only**. (string)

* [1-8]: Maximum digit number of prefilled values.

* ulong/long number: Signed or unsigned long numerical value.

* char text: Desired value to add at left side.

## Example Usage

###
 
 PrefilledCustom(5, 4, '0') = "0005"
 
 PrefilledCustom(55, 3, ' ') = "  55"

## Version History

* 1.0.0 Initial Release
  * See [commit change](https://github.com/meokullu/PreFill/commits/master) or See [release history](https://github.com/meokullu/PreFill/releases)
  * See CHANGELOG.md
  
## Task list
- [ ] Add PrefilledCustom() methods for ulong
- [ ] Add PrefilledCustom() methods for other supported data types, if they are required to use seperately from long and ulong data types for cpu-intense application usage
- [ ] Add GetNumberOfDigit method with conditional ordering to increase cpu-intense applications while values are mostly predicted about their positivity.
- [ ] Add PrefilledCustom() methods for string

## Licence
No licence is required.

## Authors
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

## Help
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

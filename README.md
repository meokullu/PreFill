# PreFill

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

![PreFill](https://repository-images.githubusercontent.com/575382775/fe896835-417e-442f-9544-a3df8a4ac154)

[Check out on NuGet gallery](https://www.nuget.org/packages/PreFill/)

## Description

PreFill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right. Supported data types: (sbyte, byte, int, uint, long, ulong, string)

PreFill is optimized for cpu-intense applications.

## Listed Methods

```
PreFilledCustom(long number, byte maxNumberOfDigit, string text = "")
```
```
PreFilledCustom(long number, byte maxNumberOfDigit, char text = '')
```
```
PrefilledCustom(ulong number, byte maxNumberOfDigit, string text = "")
```
```
PreFilledCustom(ulong number, byte maxNumberOfDigit, char text = '')
```

Returns prefilled value. (string)

* ulong/long number: Unsigned long or long number value

* byte maxNumberOfDigit: Maximum number of digit of numerical value.

* string/char text: Desired value to add at left side.

```
PreFilledCustom(string context, int maxLength, string text = "")
```
```
PreFilledCustom(string context, int maxLength, char text = '')
```
Returns prefilled value. (string)

* string context: String text value.

* int maxLength: Maximum length of text value.

* string/char text: Desired value to add at left side.

```
PreFilledCustom(List<long> numberList, string text = "")
```
```
PrefilledCustom(List<long> numberList, char text = '')
```
```
PrefilledCustom(List<ulong> numberList, string text = "")
```
```
PrefilledCustom(List<long> numberList, char text = '')
```

Returns prefilled values. (List<string>)

* List<long>/List<ulong> numberList: List of signed long or unsigned long numerical values.
 
* string/char text: Desired value to add at left side.

```
PreFilledCustom(List<string> contextList, string text = "")
```
```
PreFilledCustom(List<string) contextList, char text = '')
```

Returns prefilled values (List<string>)

* List<string> contextList: List of string values.

* string/char text: Desired value to add at left side.

```
PreFillCustom(long number, int maxNumberOfDigit, string text = "")
```
```
PreFillCustom(long number, int maxNumberOfDigit, char text = '')
```
```
PreFillCustom(ulong number, int maxNumberOfDigit, string text = "")
```
```
PreFillCustom(ulong number, int maxNumberOfDigit, char text = '')
```

Returns **prefill value only**. (string)

* ulong/long number: Signed or unsigned long numberical value.

* int maxNumberOfDigit: Maximum number of digit of numerical value.

* string/char text: Desired value to add at left side.

```
PreFill[1-8](long number, char text = '')
```
```
PreFill[1-8](ulong number, char text = '')
```

Returns **prefill value only**. (string)

* [1-8]: Maximum digit number of prefilled values.

* ulong/long number: Signed or unsigned long numerical value.

* char text: Desired value to add at left side.

```
PreFillCustom(string text, int maxLength, string stringValue = "")
```
```
PreFillCustom(string text, int maxLength, char charValue = '')
```

Returns **prefill value only**. (string)

* string text: String text value.

* int maxLength: Maximum length of string value.

* string stringValue/char charValue: Desired value to add at left side.

## Example Usage

###

* PreFilledCustom(5, 4, '0') => "0005"
* PreFilledCustom(55, 3, ' ') => "  55"
* PreFilledCustom("abc", 5, 'd') => "ddabc"
* PreFilledCustom({5, 4, 55, 45, 32, 375}, 4, '0') => {"0005", "0004", "0055", "0045", "0032", "0375"}
* PreFillCustom(5, 4, '0') => "000"
* PreFillCustom(55, 3, ' ') => " "
* PreFillCustom("abc", 5, 'd') => "dd"
* PreFillCustom({5, 4, 55, 45, 32, 375}, 4, '0') => {"   ", "   ", "  ", "  ", " "}
* PreFill1(5, ' ') => ""
* PreFill2(5, ' ') => " "
* PreFill8(5, ' ') => "       "

## Version History

# 1.3.0 (Upcoming)
 * Text length is now used to repeat of filling.
 * Support null values.

* 1.2.0
 * Added comments to methods.
  
* 1.1.0
  * See [commit change](https://github.com/meokullu/PreFill/commits/master) or See [release history](https://github.com/meokullu/PreFill/releases)
  * See [changelog](https://github.com/meokullu/PreFill/blob/master/CHANGELOG.md)

* 1.0.0 Initial Release
  * See [commit change](https://github.com/meokullu/PreFill/commits/master) or See [release history](https://github.com/meokullu/PreFill/releases)
  * See [changelog](https://github.com/meokullu/PreFill/blob/master/CHANGELOG.md)
  
## Task list

### Knowns bugs ###
- [ ] If length of desired text is more than one character repeatence of adding it may make result not aligned.

## Licence
No licence is required.

## Authors
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

## Help
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

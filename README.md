## PreFill

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

![PreFill](https://github.com/meokullu/PreFill/blob/master/Prefill/Resources/Screenshot.png)

[Download on NuGet gallery](https://www.nuget.org/packages/PreFill/)

### Description

PreFill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right. Supported data types: (sbyte, byte, int, uint, long, ulong, string)

PreFill is optimized for cpu-intense applications.

### Example Usage

* PreFilledCustom(5, 4, '0') => "0005"
* PreFilledCustom(null, 4, '0') => "0000"
* PreFilledCustom(55, 3, ' ') => " 55"
* PreFilledCustom("abc", 5, 'd') => "ddabc"
* PreFilledCustom({5, 4, 55, 45, 32, 375}, 4, '0') => {"0005", "0004", "0055", "0045", "0032", "0375"}
* PreFillCustom(5, 4, '0') => "000"
* PreFillCustom(55, 3, ' ') => " "
* PreFillCustom("abc", 5, 'd') => "dd"
* PreFillCustom({5, 4, 55, 45, 32, 375}, 4, '0') => {"   ", "   ", "  ", "  ", " "}
* PreFill1(5, ' ') => ""
* PreFill2(5, ' ') => " "
* PreFill8(5, ' ') => "       "

To check listed methods, example of output visit wiki page. [PreFill Wiki](https://github.com/meokullu/PreFill/wiki)

### Version History
See [Changelog](https://github.com/meokullu/PreFill/blob/master/CHANGELOG.md)
  
### Task list

#### Knowns bugs
- [ ] If length of desired text is more than one character repeatence of adding it may make result not aligned.

### Licence
[MIT license](https://github.com/meokullu/Prefill/blob/master/LICENSE)

### Authors
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

### Help
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

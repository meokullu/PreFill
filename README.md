## PreFill
> ⚠️ When updating to v2.2.0 from v2.1.2, due to renaming Prefill as PreFill an unexcepted error may occur. You can uninstall and install PreFill to avoid that. ⚠️

## Uninstall & install through Package Manager Control
```
Uninstall-Package Prefill
```

```
Install-Package PreFill -Version 2.2.0
```

[![PreFill](https://img.shields.io/nuget/v/PreFill.svg)](https://www.nuget.org/packages/PreFill/) [![PreFill](https://img.shields.io/nuget/dt/PreFill.svg)](https://www.nuget.org/packages/PreFill/) [![License](https://img.shields.io/github/license/meokullu/PreFill.svg)](https://github.com/meokullu/PreFill/blob/master/LICENSE)

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

![PreFill](https://github.com/meokullu/PreFill/assets/4971757/3e7c14a2-c823-4d4d-825f-74fbd74f3e18)

[Download on NuGet gallery](https://www.nuget.org/packages/PreFill/)

### Description

PreFill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right. Supported data types: (`sbyte`, `byte`, `int`, `uint`, `long`, `ulong`, `string`, `object`)

PreFill is optimized for CPU-intense applications.

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
* Create an issue or check task list: [Issues](https://github.com/meokullu/PreFill/issues)

### Licence
This repository is licensed under the "MIT" license. See [MIT license](https://github.com/meokullu/CalculateETA/blob/master/LICENSE).

### Licence
[MIT license](https://github.com/meokullu/PreFill/blob/master/LICENSE)

### Authors & Contributing

If you'd like to contribute, then contribute. [contributing guide](https://github.com/meokullu/CalculateETA/blob/master/CONTRIBUTING.md).

[![Contributors](https://contrib.rocks/image?repo=meokullu/PreFill)](https://github.com/meokullu/PreFill/graphs/contributors)

### Help
Twitter: [@enesokullu](https://twitter.com/EnesOkullu)

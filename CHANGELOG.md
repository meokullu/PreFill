## PreFill Changelog
[![PreFill](https://img.shields.io/nuget/v/PreFill.svg)](https://www.nuget.org/packages/PreFill/)

<!--
### [Unreleased]

#### Added

#### Changed

#### Removed
-->

### [2.2.2]
#### Changed
* Removed unused usings.
* Missing summaries of methods are added.

### [2.2.1]
#### Changed
* Files splitting.

### [2.2.0]
#### Added
* `PreFillCustom<T>()` and `PreFilledCustom<T>()` methods are added.

#### Changed
* `maxNumberOfDigit` renamed as `maxDigit` on `PreFilledCustom(long?... string)`, `PreFilledCustom(long?... char)`, `PreFilledCustom(long... string)`, `PreFilledCustom(long... char)`, `PreFillCustom(long?... string)`, `PreFillCustom(long?... char)`, `PreFillCustom(long... string)` and `PreFillCustom(long... char)`

### [2.1.2]
#### Changed
* New design README.
* New design CHANGELOG.
* Added method references to summaries.

### [2.1.1]
#### Added
* Added missing version informations on CHANGELOG.
* Wiki link added under Example Usage on README.
* CHANGELOG link added under Version History on README.

#### Changed
* Social media preview link fixed. 
* Folder name changed from Prefill to PreFill.
* README has better view.
* CHANGELOG has better view.
* LICENCE.md file renamed as LICENCE.

### [2.1.0]
#### Added
* Multi-framework support is added. (net6.0; net7.0; net461; netcoreapp3.1; netstandard2.0)

#### Changed

### [2.0.1]
#### Changed
* Using explicipt variable instead of `var`

### [2.0.0]
#### Changed
* Target framework is changef from .Net Core 3.1 to .Net 7.0

### [1.3.1]
#### Changed
* `PrefilledCustom` methods' name changed with `PreFilledCustom()`.

### [1.3.0]
#### Added
* `Prefill`, `PrefillCustom` methods support `null` values.
#### Changed
* `GetLengthOfString()` private method was raising an error if provided `string` context was null. `Null` checking is added.

### [1.1.0]
#### Added
* Added `GetLengthOfString()` method
* Added support `string` data type.

### [1.0.0]
Initial version.

# PreFill

PreFill is a project to align horizontally listed output values to right side in order to increase their legibility.

## Description

Prefill has methods to fill desired value preceeding of values to align them. Empty character, letter or number can be used to make different lenghted values align right.

## Listed Methods

```
* PreFilledCustom()
```

```
* PreFillCustom()
```

```
* PreFill[1-8]()
```

## Example Usage

## Version History

* 1.0.0 Initial Release
  * See [commit change]() or See [release history]()
  * See CHANGELOG.md

## Licence
No licence is required.

## Authors
[@enesokullu](https://twitter.com/EnesOkullu)

### Prefill helps you to add desired value into left side of number in order to align them right side.

#### Prefill works with both posivite and negative numbers (sbyte, byte, int, uint, long, ulong)

#### You can set maximum number of digits or Prefill can dynamically set it for you.

#### Example output:

PrefilledCustom(5, 4, '0') = '0005'

PrefilledCustom(55, 3, ' ') = ' 55'

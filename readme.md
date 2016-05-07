# DDsControlCollection
## Simple collection of controls for Windows.Forms

A bunch of WinForm controls that I'll be doing here and then.

I started this because I wanted a bit more from `ProgressBar`, and I disliked how `ProgressBar` behaved (in Windows).

Feel free to post any issues or suggestions.

### Controls

| Control | Based on | Works in Mono | Serializable | Localized |
| --- | --- | :-: | :-: | :-: |
| SimpleProgressBar | `Control` | ✔️ |  | ❌ |
| SimpleClock | `Control` | ~ |  | ❌ |

Legend

✔️ Yes

~ Yes, but with issues

❌ Cannot be applied

(empty) Not available yet

## SimpleProgressBar

### Features:

- Mostly compatible with `ProgressBar`
- Full ForeColor and BackColor support.
- Vertical and horizontal via `BarOrientation`
- Text via `Text`
  - Custom font and size
  - Text color via `TextColor`
  - Text types via `TextDisplay`
    - None (Hidden)
    - Value on maximum (value / maximum)
    - Pourcentage (NN%)
    - User defined text

### TODO:

- `ProgressBarStyle` Style (Continuous, Marquee, Blocks)
- Text AutoSize
- Serialize

## SimpleClock

- Analog clock
  - Customizable pens (Frame, seconds, minutes, hours)

### TODO:

- [Mono] Fix not applying -90deg in
- [Mono] Fix control `Size` being slightly larger
- More styles (Numeric, binary)
- Serialize
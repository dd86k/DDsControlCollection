# DDsControlCollection
## Collection of components for Windows.Forms

A bunch of WinForm controls that I'll be doing here and then.

I started this because I wanted a bit more from `ProgressBar`, and I disliked how `ProgressBar` behaved (in Windows).

Also I plan to use those in future projects.

Mostly still in development!

Feel free to post any issues or suggestions.

[MIT License](License)

## Controls

| Control | Based on | Works in Mono |
| --- | --- | :-: | :-: | :-: |
| SimpleProgressBar | `Control` | ✔️ |
| SimpleClock | `Control` | ✔️ |
| PrettyListBox | `Panel` | ️️❓ |

**Legend**

✔️ Yes

~ Yes, but with some issues

❓ Testing needed

❌ Not applicable

(empty) Not available yet

## SimpleProgressBar

Goal: A mostly-compatible `ProgressBar` with some WPF properties and extra features.

So far:
- ForeColor and BackColor support.
- Padding support.
- Border property.
- Vertical and horizontal via `BarOrientation`
  - Inversion is possible
- Text via `Text`
  - Custom font and size
  - Text color via `TextColor`
  - Text types via `TextDisplay`
    - None (Hidden)
    - Value on maximum (value / maximum)
    - Pourcentage (NN%)
    - User defined text

## SimpleClock

Goal: A simple customizable clock with custom properties.

So far:
- Analog clock
  - Customizable colors
  - Customizable widths

## PrettyListBox

Goal: A prettier, customizable, compatible `ListBox`.

So far:
- Custom focus color
- Item padding
- Auto-invert selected item


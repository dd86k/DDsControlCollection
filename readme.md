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
| PrettyListBox | `Panel` | ️️✔️ |

**Legend**

✔️ Yes

~ Yes, but with some issues

🔃 Information needs to be refreshed

❓ Unknown

❌ Not applicable

(empty) Not available yet

## SimpleProgressBar

Goal: A mostly-compatible `ProgressBar` with some WPF properties and extra features.

So far:
- ForeColor and BackColor support.
- Padding support via `Padding`.
- Border property via `BorderWidth` and `BorderColor`.
- Vertical and horizontal orientations via `BarOrientation`.
  - Inversion is possible via `InvertOrientation` (`RightToLeft` also applies).
- Text via `Text`.
  - Custom font and size.
  - Text color via `TextColor`.
  - Text types via `TextDisplay`.
    - `None` - Hidden
    - `ValueOnmaximum` - Value / Maximum
    - `Pourcentage` - Number%
    - `UserDefined` - Manually defined
- Marquee style via `MarqueeAnimation`.
  - `Bouncy` - Block bouncing back and forth.
  - `Slide` - Sliding animation like the one found in Windows.

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


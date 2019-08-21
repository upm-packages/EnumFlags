# Enum Flags

![image](https://user-images.githubusercontent.com/838945/63412383-9e9cdd00-c432-11e9-8bd8-c7d774b7a93f.png)

EnumFlags provides `[EnumFlags]` attribute to render multiple selection listbox in Inspector.

## Installation

```bash
upm add package dev.upm-packages.enumflags
```

Please refer to [this repository](https://github.com/upm-packages/upm-cli) about the `upm` command.

### Scoped Registry

This package has published at [**Unofficial Unity Package Manager Registry**](https://upm-packages.dev).

Please setup scoped registry in `Packages/manifest.json` to use this package.

```json
"scopedRegistries": [
  {
    "name": "Unofficial Unity Package Manager Registry",
    "url": "https://upm-packages.dev",
    "scopes": [
      "dev.upm-packages"
    ]
  }
]
```

## Usages

### Annotate `enum` using `[System.Flags]`

```csharp
using System;

[Flags]
public enum SampleFlag
{
    Foo = 1 << 0,
    Bar = 1 << 1,
    Buz = 1 << 2,
    Quz = 1 << 3,
}
```

Note: It's strongly recommended to set value explicitly by bit shift.

### Annotate serializable fields using `[EnumFlags.EnumFlags]`

```csharp
using UnityEngine;
using EnumFlags;

public SampleComponent : MonoBehaviour
{
    [SerializeField]
    [EnumFlags]
    private SampleFlag flag = default;

    public SampleFlag Flag => flag;

    private void Start()
    {
        Debug.Log($"Value: {Flag}");
    }
}
```

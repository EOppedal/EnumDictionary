using System;
using System.Collections.Generic;

public sealed record EnumDictionary<TEnum, TValue> where TEnum : Enum {
    private readonly Dictionary<TEnum, TValue> _dictionary = new();

    public EnumDictionary(params TValue[] values) {
        var enumValues = (TEnum[])Enum.GetValues(typeof(TEnum));

        for (var i = 0; i < enumValues.Length; i++) {
            _dictionary.Add(enumValues[i], values[i]);
        }
    }

    public TValue this[TEnum key] => _dictionary[key];
}
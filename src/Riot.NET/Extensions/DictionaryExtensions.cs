﻿using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace RiotNET.Extensions
{
    public static class DictionaryExtensions
    {
        /// <inheritdoc cref="ReadOnlyDictionary{TKey, TValue}.ReadOnlyDictionary(IDictionary{TKey, TValue})"/>
        public static ReadOnlyDictionary<TKey, TValue> ReadOnly<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary) where TKey : notnull => new(dictionary);
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an item is added, modified, deleted or unchanged.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5rSSUA4SEeKGXqvMN6jpiw")]
[Description(@"Specifies if an item is added, modified, deleted or unchanged.")]
[DerivedFrom(typeof(ModificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Modification1Code>))]
#endif
public enum Modification1Code
{
    /// <summary>
    /// Specifies that the item is not changed.
    /// Encoded/decoded by serializers as &quot;NOCH&quot;.
    /// </summary>
    [EnumMember(Value = "NOCH")]
    [IsoId("_7OFh0Q4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is not changed.")]
    NoChange = ModificationCode.NoChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the item is modified.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_7V-5kQ4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is modified.")]
    Modification = ModificationCode.Modification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the item is deleted.
    /// Encoded/decoded by serializers as &quot;DELE&quot;.
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_7eCCUQ4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is deleted.")]
    Deletion = ModificationCode.Deletion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the item is added.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_7gjx4Q4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is added.")]
    Addition = ModificationCode.Addition, // same ordinal as derivation source for type conversions
}

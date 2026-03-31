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
[IsoId("_d9DQsA4SEeKGXqvMN6jpiw")]
[Description(@"Specifies if an item is added, modified, deleted or unchanged.")]
[Derivations(typeof(Modification1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModificationCode>))]
#endif
public enum ModificationCode
{
    /// <summary>
    /// Specifies that the item is added.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_m-gDEA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is added.")]
    Addition,

    /// <summary>
    /// Specifies that the item is deleted.
    /// Encoded/decoded by serializers as &quot;DELE&quot;.
    /// </summary>
    [EnumMember(Value = "DELE")]
    [IsoId("_sspRoA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is deleted.")]
    Deletion,

    /// <summary>
    /// Specifies that the item is modified.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_xaHGUA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is modified.")]
    Modification,

    /// <summary>
    /// Specifies that the item is not changed.
    /// Encoded/decoded by serializers as &quot;NOCH&quot;.
    /// </summary>
    [EnumMember(Value = "NOCH")]
    [IsoId("_0_AwcA4SEeKGXqvMN6jpiw")]
    [Description(@"Specifies that the item is not changed.")]
    NoChange,
}

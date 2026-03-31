// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the quantity or amount is to be delivered or received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O0zXoHvLEemW9qhOy0scyg")]
[Description(@"Specifies whether the quantity or amount is to be delivered or received.")]
[DerivedFrom(typeof(EntryTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralEntryType1Code>))]
#endif
public enum CollateralEntryType1Code
{
    /// <summary>
    /// Financial Instruments or amount are to be delivered out of Party A&apos;s account.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_Qe13kXvLEemW9qhOy0scyg")]
    [Description(@"Financial Instruments or amount are to be delivered out of Party A's account.|")]
    Delivered = EntryTypeCode.Delivered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Instruments  or amount are to be received in Party A&apos;s account.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_QjH6oXvLEemW9qhOy0scyg")]
    [Description(@"Financial Instruments  or amount are to be received in Party A's account.|")]
    Received = EntryTypeCode.Received, // same ordinal as derivation source for type conversions
}

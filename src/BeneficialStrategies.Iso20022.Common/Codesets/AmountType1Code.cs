// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of the amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be0Ksdp-Ed-ak6NoX_4Aeg_334790339")]
[Description(@"Specifies the value of the amount.")]
[DerivedFrom(typeof(AmountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AmountType1Code>))]
#endif
public enum AmountType1Code
{
    /// <summary>
    /// The amount is open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_be0Kstp-Ed-ak6NoX_4Aeg_334790348")]
    [Description(@"The amount is open.")]
    Open = AmountTypeCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The amount is unkown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_be0Ks9p-Ed-ak6NoX_4Aeg_334790370")]
    [Description(@"The amount is unkown.")]
    Unknown = AmountTypeCode.Unknown, // same ordinal as derivation source for type conversions
}

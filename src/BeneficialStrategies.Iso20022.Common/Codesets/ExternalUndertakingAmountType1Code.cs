// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MhZAm7iEeKo25nLKvGr8w_-1404704925")]
[Description(
    @"Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalUndertakingAmountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalUndertakingAmountType1Code>))]
#endif
public enum ExternalUndertakingAmountType1Code
{
    /// <summary>
    /// Amount is an increase.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_uQxp-_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount is an increase.")]
    Increase = ExternalUndertakingAmountTypeCode.Increase, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount is a reduction.
    /// Encoded/decoded by serializers as &quot;REDC&quot;.
    /// </summary>
    [EnumMember(Value = "REDC")]
    [IsoId("_uQ7a8vRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is a reduction.")]
    Reduction = ExternalUndertakingAmountTypeCode.Reduction, // same ordinal as derivation source for type conversions
}

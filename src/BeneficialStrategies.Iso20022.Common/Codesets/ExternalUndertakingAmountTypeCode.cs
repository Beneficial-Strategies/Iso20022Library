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
[IsoId("_-MhZA27iEeKo25nLKvGr8w_1180759625")]
[Description(
    @"Specifies the external undertaking amount type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUndertakingAmountType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalUndertakingAmountTypeCode>))]
#endif
public enum ExternalUndertakingAmountTypeCode
{
    /// <summary>
    /// Amount is an increase.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_uQxp-fRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is an increase.")]
    Increase,

    /// <summary>
    /// Amount is a reduction.
    /// Encoded/decoded by serializers as &quot;REDC&quot;.
    /// </summary>
    [EnumMember(Value = "REDC")]
    [IsoId("_uQ7a8PRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is a reduction.")]
    Reduction,
}

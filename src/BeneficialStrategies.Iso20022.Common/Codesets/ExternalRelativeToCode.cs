// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPE27iEeKo25nLKvGr8w_-1433191435")]
[Description(
    @"Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalRelativeTo1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalRelativeToCode>))]
#endif
public enum ExternalRelativeToCode
{
    /// <summary>
    /// Percentage rate expressed relative to the value of goods.
    /// Encoded/decoded by serializers as &quot;GOOD&quot;.
    /// </summary>
    [EnumMember(Value = "GOOD")]
    [IsoId("_uQCDEPRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the value of goods.")]
    ValueOfGoods,

    /// <summary>
    /// Percentage rate expressed relative to the payment amount.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uQCDE_RYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the payment amount.")]
    PaymentAmount,

    /// <summary>
    /// Percentage rate expressed relative to the undertaking amount.
    /// Encoded/decoded by serializers as &quot;UNDG&quot;.
    /// </summary>
    [EnumMember(Value = "UNDG")]
    [IsoId("_uQCDFvRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the undertaking amount.")]
    UndertakingAmount,
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPEm7iEeKo25nLKvGr8w_-593632971")]
[Description(
    @"Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalRelativeToCode))]
public enum ExternalRelativeTo1Code
{
    /// <summary>
    /// Percentage rate expressed relative to the value of goods.
    /// Encoded/decoded by serializers as &quot;GOOD&quot;.
    /// </summary>
    [EnumMember(Value = "GOOD")]
    [IsoId("_uQCDEvRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the value of goods.")]
    ValueOfGoods = ExternalRelativeToCode.ValueOfGoods, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage rate expressed relative to the payment amount.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uQCDFfRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the payment amount.")]
    PaymentAmount = ExternalRelativeToCode.PaymentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage rate expressed relative to the undertaking amount.
    /// Encoded/decoded by serializers as &quot;UNDG&quot;.
    /// </summary>
    [EnumMember(Value = "UNDG")]
    [IsoId("_uQCDGPRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the undertaking amount.")]
    UndertakingAmount = ExternalRelativeToCode.UndertakingAmount, // same ordinal as derivation source for type conversions
}

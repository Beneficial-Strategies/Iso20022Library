// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t7boglkyEeGeoaLUQk__nA_611729510")]
[Description(@"Specifies the nature, or use, of the amount in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDiscountAmountTypeCode))]
public enum ExternalDiscountAmountType1Code
{
    /// <summary>
    /// Addition discount based on third-party agreed business promotional activity, i.e., extra 10 percent discount for 15 days)
    /// Encoded/decoded by serializers as &quot;APDS&quot;.
    /// </summary>
    [EnumMember(Value = "APDS")]
    [IsoId("_uMAesvRYEeuLhpyIdtJzwg")]
    [Description(@"Addition discount based on third-party agreed business promotional activity, i.e., extra 10 percent discount for 15 days)")]
    AdditionalPromotionalDiscount = ExternalDiscountAmountTypeCode.AdditionalPromotionalDiscount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Discount based on volume purchased.
    /// Encoded/decoded by serializers as &quot;STDS&quot;.
    /// </summary>
    [EnumMember(Value = "STDS")]
    [IsoId("_uMAetfRYEeuLhpyIdtJzwg")]
    [Description(@"Discount based on volume purchased.")]
    StandingDiscount = ExternalDiscountAmountTypeCode.StandingDiscount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Discount based on terms negotiated for payment within a specified time period, i.e., 2/10 Net 30 (2 percent discount if paid in 10 days; otherwise, net amount is due in 30 days).
    /// Encoded/decoded by serializers as &quot;TMDS&quot;.
    /// </summary>
    [EnumMember(Value = "TMDS")]
    [IsoId("_uMAeuPRYEeuLhpyIdtJzwg")]
    [Description(@"Discount based on terms negotiated for payment within a specified time period, i.e., 2/10 Net 30 (2 percent discount if paid in 10 days; otherwise, net amount is due in 30 days).")]
    TermsDiscount = ExternalDiscountAmountTypeCode.TermsDiscount, // same ordinal as derivation source for type conversions
    
}

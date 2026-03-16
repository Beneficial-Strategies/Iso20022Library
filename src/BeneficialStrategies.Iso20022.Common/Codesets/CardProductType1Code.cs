// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of card product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hoOYMGtZEeSKOvNNYJQdoQ")]
[Description(@"Type of card product.")]
[DerivedFrom(typeof(CardProductTypeCode))]
public enum CardProductType1Code
{
    /// <summary>
    /// Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_l5gnMWtZEeSKOvNNYJQdoQ")]
    [Description(
        @"Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes."
    )]
    CommercialCard = CardProductTypeCode.CommercialCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cards issued as a means of personal expenditure. The user is always an individual.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_l_LKUWtZEeSKOvNNYJQdoQ")]
    [Description(
        @"Cards issued as a means of personal expenditure. The user is always an individual."
    )]
    ConsumerCard = CardProductTypeCode.ConsumerCard, // same ordinal as derivation source for type conversions
}

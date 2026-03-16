// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of card product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SaRAQGtZEeSKOvNNYJQdoQ")]
[Description(@"Type of card product.")]
[Derivations(typeof(CardProductType1Code))]
public enum CardProductTypeCode
{
    /// <summary>
    /// Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_W0DrAGtZEeSKOvNNYJQdoQ")]
    [Description(
        @"Cards issued as a means of business expenditure, for instance business card or corporate card. The user could be a company, an individual for business expenses or a self employed for business purposes."
    )]
    CommercialCard,

    /// <summary>
    /// Cards issued as a means of personal expenditure. The user is always an individual.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bxmjEGtZEeSKOvNNYJQdoQ")]
    [Description(
        @"Cards issued as a means of personal expenditure. The user is always an individual."
    )]
    ConsumerCard,
}

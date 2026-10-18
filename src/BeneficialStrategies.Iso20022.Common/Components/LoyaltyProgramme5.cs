// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty Programme5.
/// </summary>
[IsoId("_OykWwXTnEe6h-4AZRg9sVg")]
[DisplayName("Loyalty Programme5")]
public record LoyaltyProgramme5
{
    /// <summary>
    /// Eligibility.
    /// </summary>
    [DisplayName("Eligibility")]
    [IsoXmlTag("Elgblty")]
    public ValueList<TrueFalseIndicator> Eligibility { get; init; } = [];

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public Max35Text? Issuer { get; init; }

    /// <summary>
    /// Member Name.
    /// </summary>
    [DisplayName("Member Name")]
    [IsoXmlTag("MmbNm")]
    public CardholderName3? MemberName { get; init; }

    /// <summary>
    /// Member Address.
    /// </summary>
    [DisplayName("Member Address")]
    [IsoXmlTag("MmbAdr")]
    public Address2? MemberAddress { get; init; }

    /// <summary>
    /// Member Identification.
    /// </summary>
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    public Max35Text? MemberIdentification { get; init; }

    /// <summary>
    /// Member Status.
    /// </summary>
    [DisplayName("Member Status")]
    [IsoXmlTag("MmbSts")]
    public Max35Text? MemberStatus { get; init; }

    /// <summary>
    /// Expiration Date.
    /// </summary>
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public ISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public Max10NumericText? Value { get; init; }

    /// <summary>
    /// Value Type.
    /// </summary>
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public LoyaltyValueType1Code? ValueType { get; init; }

    /// <summary>
    /// Other Value Type.
    /// </summary>
    [DisplayName("Other Value Type")]
    [IsoXmlTag("OthrValTp")]
    public Max35Text? OtherValueType { get; init; }

    /// <summary>
    /// Value To Credit.
    /// </summary>
    [DisplayName("Value To Credit")]
    [IsoXmlTag("ValToCdt")]
    public Max10NumericText? ValueToCredit { get; init; }

    /// <summary>
    /// Value To Debit.
    /// </summary>
    [DisplayName("Value To Debit")]
    [IsoXmlTag("ValToDbt")]
    public Max10NumericText? ValueToDebit { get; init; }

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public Max10NumericText? Balance { get; init; }
}

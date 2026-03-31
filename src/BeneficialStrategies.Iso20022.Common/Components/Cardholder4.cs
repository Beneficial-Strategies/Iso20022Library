// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
[IsoId("_kx49oTSKEeK8M6X9iBRU5A")]
[DisplayName("Cardholder")]
public record Cardholder4
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_k72x8TSKEeK8M6X9iBRU5A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<CardholderIdentification1> Identification { get; init; } = [];

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_k72x9TSKEeK8M6X9iBRU5A")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    [IsoId("_k72x-TSKEeK8M6X9iBRU5A")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication4> Authentication { get; init; } = [];

    /// <summary>
    /// Numeric characters of the cardholder&apos;s address for verification.
    /// </summary>
    [IsoId("_k72x_TSKEeK8M6X9iBRU5A")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_k72yATSKEeK8M6X9iBRU5A")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}

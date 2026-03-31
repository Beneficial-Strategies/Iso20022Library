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
[IsoId("_SqbqzAEcEeCQm6a_G2yO_w_912220241")]
[DisplayName("Cardholder")]
public record Cardholder2
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_SqbqzQEcEeCQm6a_G2yO_w_-1648920024")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<CardholderIdentification1> Identification { get; init; } = [];

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_SqbqzgEcEeCQm6a_G2yO_w_-280784447")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    [IsoId("_Sqk0sAEcEeCQm6a_G2yO_w_-916509742")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication2> Authentication { get; init; } = [];

    /// <summary>
    /// Numeric characters of the cardholder&apos;s address for verification.
    /// </summary>
    [IsoId("_Sqk0sQEcEeCQm6a_G2yO_w_799334401")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_Sqk0sgEcEeCQm6a_G2yO_w_-1277856800")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}

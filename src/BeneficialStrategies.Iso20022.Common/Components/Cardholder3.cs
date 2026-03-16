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
[IsoId("_sQRWgQvUEeKzJ69IWwzB9Q")]
[DisplayName("Cardholder")]
public record Cardholder3
{
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_sbuYkQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<CardholderIdentification1> Identification { get; init; } = [];

    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_sbuYlQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; }

    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// </summary>
    [IsoId("_sbuYmQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; }

    /// <summary>
    /// Data related to the authentication of the cardholder.
    /// </summary>
    [IsoId("_sbuYnQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication3> Authentication { get; init; } = [];

    /// <summary>
    /// Numeric characters of the cardholder&apos;s address for verification.
    /// </summary>
    [IsoId("_sbuYoQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Address Verification")]
    [IsoXmlTag("AdrVrfctn")]
    public AddressVerification1? AddressVerification { get; init; }

    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_sbuYpQvUEeKzJ69IWwzB9Q")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; }
}

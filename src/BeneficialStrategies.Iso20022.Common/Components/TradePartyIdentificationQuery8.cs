// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query of a trade party based on the identification.
/// </summary>
[IsoId("_FHEpEZQTEeiok48Eh9lW9Q")]
[DisplayName("Trade Party Identification Query")]
public record TradePartyIdentificationQuery8
{
    /// <summary>
    /// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_FS0mEZQTEeiok48Eh9lW9Q")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Business identifier code used to identify the trade party.
    /// </summary>
    [IsoId("_FS0mE5QTEeiok48Eh9lW9Q")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the client counterparty.
    /// </summary>
    [IsoId("_FS0mFZQTEeiok48Eh9lW9Q")]
    [DisplayName("Client Identification")]
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? ClientIdentification { get; init; }

    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_FS0mF5QTEeiok48Eh9lW9Q")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}

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
[IsoId("_wy740dLlEem1A4OOmCK97A")]
[DisplayName("Trade Party Identification Query")]
public record TradePartyIdentificationQuery9
{
    /// <summary>
    /// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    [IsoId("_w3bXQ9LlEem1A4OOmCK97A")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Country where the registered office of the counterparty is located or country of residence in case that the counterparty is a natural person.
    /// </summary>
    [IsoId("_5YHl8dLlEem1A4OOmCK97A")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public CountryCode? CountryCode { get; init; }

    /// <summary>
    /// Business identifier code used to identify the trade party.
    /// </summary>
    [IsoId("_w3bXRdLlEem1A4OOmCK97A")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the client counterparty.
    /// </summary>
    [IsoId("_w3bXR9LlEem1A4OOmCK97A")]
    [DisplayName("Client Identification")]
    [IsoXmlTag("ClntId")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? ClientIdentification { get; init; }

    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_w3bXSdLlEem1A4OOmCK97A")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}

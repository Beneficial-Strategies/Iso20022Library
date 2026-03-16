// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Exchange26.
/// </summary>
[IsoId("_rA87IT6lEe-QZYT2pcGFZw")]
[DisplayName("Currency Exchange26")]
public record CurrencyExchange26
{
    /// <summary>
    /// Foreign Exchange Agent.
    /// </summary>
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    public BranchAndFinancialInstitutionIdentification8? ForeignExchangeAgent { get; init; }

    /// <summary>
    /// Pre Agreed Exchange Rate.
    /// </summary>
    [DisplayName("Pre Agreed Exchange Rate")]
    [IsoXmlTag("PreAgrdXchgRate")]
    public required IsoBaseOneRate PreAgreedExchangeRate { get; init; }

    /// <summary>
    /// Quotation Date Time.
    /// </summary>
    [DisplayName("Quotation Date Time")]
    [IsoXmlTag("QtnDtTm")]
    public IsoISODateTime? QuotationDateTime { get; init; }

    /// <summary>
    /// Quoted Currency.
    /// </summary>
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveOrHistoricCurrencyCode? QuotedCurrency { get; init; }

    /// <summary>
    /// Quote Identification.
    /// </summary>
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    public IsoUUIDv4Identifier? QuoteIdentification { get; init; }

    /// <summary>
    /// Unit Currency.
    /// </summary>
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; }
}

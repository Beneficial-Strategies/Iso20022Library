// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICurrencyExchange26"/>
[Description(@"Set of elements used to provide details of the currency exchange.")]
[IsoId("_rA87IT6lEe-QZYT2pcGFZw")]
[DisplayName("Currency Exchange26")]
public partial record CurrencyExchange26
{
    /// <inheritdoc cref="ICurrencyExchange26.ForeignExchangeAgent"/>
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    public BranchAndFinancialInstitutionIdentification8? ForeignExchangeAgent { get; init; }

    /// <inheritdoc cref="ICurrencyExchange26.PreAgreedExchangeRate"/>
    [DisplayName("Pre Agreed Exchange Rate")]
    [IsoXmlTag("PreAgrdXchgRate")]
    public required IsoBaseOneRate PreAgreedExchangeRate { get; init; }

    /// <inheritdoc cref="ICurrencyExchange26.QuotationDateTime"/>
    [DisplayName("Quotation Date Time")]
    [IsoXmlTag("QtnDtTm")]
    public IsoISODateTime? QuotationDateTime { get; init; }

    /// <inheritdoc cref="ICurrencyExchange26.QuotedCurrency"/>
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveOrHistoricCurrencyCode? QuotedCurrency { get; init; }

    /// <inheritdoc cref="ICurrencyExchange26.QuoteIdentification"/>
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    public IsoUUIDv4Identifier? QuoteIdentification { get; init; }

    /// <inheritdoc cref="ICurrencyExchange26.UnitCurrency"/>
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; }
}

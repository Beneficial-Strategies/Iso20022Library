// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
/// </summary>
[IsoId("_NSdW8bZoEfCUZfsQO4rYeA")]
[DisplayName("Currency Conversion34")]
public record CurrencyConversion34
{
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_NTX89bZoEfCUZfsQO4rYeA")]
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_NTX8-7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyDetails3 TargetCurrency { get; init; }

    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_NTX9AbZoEfCUZfsQO4rYeA")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public ImpliedCurrencyAndAmount? ResultingAmount { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_NTX9B7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoPercentageRate ExchangeRate { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_NTX9DbZoEfCUZfsQO4rYeA")]
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    public IsoPercentageRate? InvertedExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_NTX9E7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Specifies when the currency conversion could start.
    /// </summary>
    [IsoId("_NTX9GbZoEfCUZfsQO4rYeA")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public IsoISODateTime? ValidFrom { get; init; }

    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_NTht8bZoEfCUZfsQO4rYeA")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    public IsoISODateTime? ValidUntil { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_NTht97ZoEfCUZfsQO4rYeA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyDetails2 SourceCurrency { get; init; }

    /// <summary>
    /// Range of Bin for which the conversion is possible.
    /// </summary>
    [IsoId("_NTht_bZoEfCUZfsQO4rYeA")]
    [DisplayName("Applicable Bin Range")]
    [IsoXmlTag("AplblBinRg")]
    public ValueList<BinRange1> ApplicableBinRange { get; init; } = [];

    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_NThuA7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public OriginalAmountDetails1? OriginalAmount { get; init; }

    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_NThuCbZoEfCUZfsQO4rYeA")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission19> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_NThuD7ZoEfCUZfsQO4rYeA")]
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public ValueList<Commission18> MarkUpDetails { get; init; } = [];

    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_NThuFbZoEfCUZfsQO4rYeA")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public ValueList<ActionMessage12> DeclarationDetails { get; init; } = [];
}

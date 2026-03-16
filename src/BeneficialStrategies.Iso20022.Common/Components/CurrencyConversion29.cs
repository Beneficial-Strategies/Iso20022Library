// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion29.
/// </summary>
[IsoId("_MKqkcZFDEe6reqfAp4CunQ")]
[DisplayName("Currency Conversion29")]
public record CurrencyConversion29
{
    /// <summary>
    /// Applicable Bin Range.
    /// </summary>
    [DisplayName("Applicable Bin Range")]
    [IsoXmlTag("AplblBinRg")]
    public ValueList<BinRange1> ApplicableBinRange { get; init; } = [];

    /// <summary>
    /// Commission Details.
    /// </summary>
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission19> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Currency Conversion Identification.
    /// </summary>
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; }

    /// <summary>
    /// Declaration Details.
    /// </summary>
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public ValueList<ActionMessage11> DeclarationDetails { get; init; } = [];

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoPercentageRate ExchangeRate { get; init; }

    /// <summary>
    /// Inverted Exchange Rate.
    /// </summary>
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    public IsoPercentageRate? InvertedExchangeRate { get; init; }

    /// <summary>
    /// Mark Up Details.
    /// </summary>
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public ValueList<Commission18> MarkUpDetails { get; init; } = [];

    /// <summary>
    /// Original Amount.
    /// </summary>
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public OriginalAmountDetails1? OriginalAmount { get; init; }

    /// <summary>
    /// Quotation Date.
    /// </summary>
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Resulting Amount.
    /// </summary>
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public ImpliedCurrencyAndAmount? ResultingAmount { get; init; }

    /// <summary>
    /// Source Currency.
    /// </summary>
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyDetails2 SourceCurrency { get; init; }

    /// <summary>
    /// Target Currency.
    /// </summary>
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyDetails3 TargetCurrency { get; init; }

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public IsoISODateTime? ValidFrom { get; init; }

    /// <summary>
    /// Valid Until.
    /// </summary>
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    public IsoISODateTime? ValidUntil { get; init; }
}

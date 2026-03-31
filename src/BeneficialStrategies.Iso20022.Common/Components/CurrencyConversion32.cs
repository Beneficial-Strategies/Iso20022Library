// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency Conversion32.
/// </summary>
[IsoId("_qzA3kZ9iEe-nbM0aSPcoiQ")]
[DisplayName("Currency Conversion32")]
public record CurrencyConversion32
{
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
    public ActionMessage5? DeclarationDetails { get; init; }

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
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; }

    /// <summary>
    /// Quotation Date.
    /// </summary>
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Reference Rate.
    /// </summary>
    [DisplayName("Reference Rate")]
    [IsoXmlTag("RefRate")]
    public ATMExchangeRateComponent1? ReferenceRate { get; init; }

    /// <summary>
    /// Resulting Amount.
    /// </summary>
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; }

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
    public required CurrencyDetails2 TargetCurrency { get; init; }

    /// <summary>
    /// Valid Until.
    /// </summary>
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    public IsoISODateTime? ValidUntil { get; init; }
}

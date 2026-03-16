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
[IsoId("_IEwCUWkGEeS7zPBpvm732w")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion2
{
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_IRrEAWkGEeS7zPBpvm732w")]
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_IRrEB2kGEeS7zPBpvm732w")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyDetails1 TargetCurrency { get; init; }

    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_IRrED2kGEeS7zPBpvm732w")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_IRrEEWkGEeS7zPBpvm732w")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ExchangeRate { get; init; }

    /// <summary>
    /// Exchange rate expressed as a decimal, for example 0.7 is 7/10 and 70%.
    /// </summary>
    [IsoId("_sm5UIGkHEeS7zPBpvm732w")]
    [DisplayName("Exchange Rate Decimal")]
    [IsoXmlTag("XchgRateDcml")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRateDecimal { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_IRrEE2kGEeS7zPBpvm732w")]
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InvertedExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_IRrEFWkGEeS7zPBpvm732w")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_IRrEF2kGEeS7zPBpvm732w")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidUntil { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_IRrEGWkGEeS7zPBpvm732w")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyDetails1 SourceCurrency { get; init; }

    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_IRrEIWkGEeS7zPBpvm732w")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; }

    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_IRrEI2kGEeS7zPBpvm732w")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission19> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_IRrEJWkGEeS7zPBpvm732w")]
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public ValueList<Commission18> MarkUpDetails { get; init; } = [];

    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_IRrEJ2kGEeS7zPBpvm732w")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? DeclarationDetails { get; init; }
}

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
[IsoId("_WaxKUEerEeODR7vDcYOqmg")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion1
{
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_iZT_8EerEeODR7vDcYOqmg")]
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; }

    /// <summary>
    /// Result of a requested currency conversion.
    /// </summary>
    [IsoId("_7B4bsEesEeODR7vDcYOqmg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required CurrencyConversionResponse1Code Result { get; init; }

    /// <summary>
    /// Plain text explaining the result of the currency conversion request.
    /// </summary>
    [IsoId("_BE5HAEetEeODR7vDcYOqmg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_HGQMgEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyCode TargetCurrency { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_R98u0EetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency Numeric")]
    [IsoXmlTag("TrgtCcyNmrc")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText TargetCurrencyNumeric { get; init; }

    /// <summary>
    /// Maximal number of digits after the decimal separator for target currency.
    /// </summary>
    [IsoId("_W5SncEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency Decimal")]
    [IsoXmlTag("TrgtCcyDcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TargetCurrencyDecimal { get; init; }

    /// <summary>
    /// Full name of the target currency.
    /// </summary>
    [IsoId("_eAabIEetEeODR7vDcYOqmg")]
    [DisplayName("Target Currency Name")]
    [IsoXmlTag("TrgtCcyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TargetCurrencyName { get; init; }

    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_l_aSAEetEeODR7vDcYOqmg")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_qOWXoEetEeODR7vDcYOqmg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ExchangeRate { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_wIbJYEetEeODR7vDcYOqmg")]
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InvertedExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_6I698EetEeODR7vDcYOqmg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("__syPIEetEeODR7vDcYOqmg")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidUntil { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_GMGb8EeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_KxOM8EeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Numeric")]
    [IsoXmlTag("SrcCcyNmrc")]
    public CurrencyCode? SourceCurrencyNumeric { get; init; }

    /// <summary>
    /// Maximal number of digits after the decimal separator for source currency.
    /// </summary>
    [IsoId("_RlVlEEeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Decimal")]
    [IsoXmlTag("SrcCcyDcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SourceCurrencyDecimal { get; init; }

    /// <summary>
    /// Full name of the source currency.
    /// </summary>
    [IsoId("_YRNnMEeuEeODR7vDcYOqmg")]
    [DisplayName("Source Currency Name")]
    [IsoXmlTag("SrcCcyNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SourceCurrencyName { get; init; }

    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_cvM1cEeuEeODR7vDcYOqmg")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; }

    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_jvGxYEevEeODR7vDcYOqmg")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission19? CommissionDetails { get; init; }

    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_WkHhUEewEeODR7vDcYOqmg")]
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public Commission18? MarkUpDetails { get; init; }

    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_dbdMkEewEeODR7vDcYOqmg")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? DeclarationDetails { get; init; }
}

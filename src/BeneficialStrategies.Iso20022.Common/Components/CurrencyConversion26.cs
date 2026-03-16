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
[IsoId("_3dNVAXDLEe2MCaKO5AtGsA")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion26
{
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_3kXF4XDLEe2MCaKO5AtGsA")]
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_3kXF43DLEe2MCaKO5AtGsA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyDetails3 TargetCurrency { get; init; }

    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_3kXF5XDLEe2MCaKO5AtGsA")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public ImpliedCurrencyAndAmount? ResultingAmount { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_3kXF53DLEe2MCaKO5AtGsA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ExchangeRate { get; init; }

    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_3kXF6XDLEe2MCaKO5AtGsA")]
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InvertedExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_3kXF63DLEe2MCaKO5AtGsA")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Specifies when the currency conversion could start.
    /// </summary>
    [IsoId("_7ysSEHDMEe2MCaKO5AtGsA")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidFrom { get; init; }

    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_3kYUAXDLEe2MCaKO5AtGsA")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidUntil { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_3kYUA3DLEe2MCaKO5AtGsA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyDetails2 SourceCurrency { get; init; }

    /// <summary>
    /// Range of Bin for which the conversion is possible.
    /// </summary>
    [IsoId("_v_oeQHDNEe2MCaKO5AtGsA")]
    [DisplayName("Applicable Bin Range")]
    [IsoXmlTag("AplblBinRg")]
    public BinRange1? ApplicableBinRange { get; init; }

    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_3kYUBXDLEe2MCaKO5AtGsA")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public OriginalAmountDetails1? OriginalAmount { get; init; }

    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_3kYUB3DLEe2MCaKO5AtGsA")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission19? CommissionDetails { get; init; }

    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_3kYUCXDLEe2MCaKO5AtGsA")]
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public Commission18? MarkUpDetails { get; init; }

    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_3kYUC3DLEe2MCaKO5AtGsA")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public ActionMessage10? DeclarationDetails { get; init; }
}

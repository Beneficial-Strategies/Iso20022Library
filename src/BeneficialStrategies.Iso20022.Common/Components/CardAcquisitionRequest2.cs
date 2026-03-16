// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request to card data acquisition.
/// </summary>
[IsoId("_mmNwMYYEEemxIqbaFEE8-w")]
[DisplayName("Card Acquisition Request")]
public record CardAcquisitionRequest2
{
    /// <summary>
    /// Card payment brands allowed by the Sale System for the payment transaction.
    /// </summary>
    [IsoId("_mxLDAYYEEemxIqbaFEE8-w")]
    [DisplayName("Allowed Payment Brand")]
    [IsoXmlTag("AllwdPmtBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AllowedPaymentBrand { get; init; }

    /// <summary>
    /// Loyalty brands or programs allowed by the Sale System for the loyalty transaction.
    /// </summary>
    [IsoId("_mxLDA4YEEemxIqbaFEE8-w")]
    [DisplayName("Allowed Loyalty Brand")]
    [IsoXmlTag("AllwdLltyBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AllowedLoyaltyBrand { get; init; }

    /// <summary>
    /// Indicates if the Customer realises the selection of the card application.
    /// </summary>
    [IsoId("_mxLDBYYEEemxIqbaFEE8-w")]
    [DisplayName("Force Customer Selection Flag")]
    [IsoXmlTag("ForceCstmrSelctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ForceCustomerSelectionFlag { get; init; }

    /// <summary>
    /// Amount of the transaction. It allows the processing of a contactless card.
    /// </summary>
    [IsoId("_mxLDB4YEEemxIqbaFEE8-w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_mxLDCYYEEemxIqbaFEE8-w")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public CardPaymentServiceType13Code? PaymentType { get; init; }

    /// <summary>
    /// Indicates if Cashback is allowed
    /// </summary>
    [IsoId("_mxLDC4YEEemxIqbaFEE8-w")]
    [DisplayName("Cash Back Flag")]
    [IsoXmlTag("CshBckFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CashBackFlag { get; init; }

    /// <summary>
    /// The POI System receives this information.
    /// </summary>
    [IsoId("_kR1Sw4YEEemxIqbaFEE8-w")]
    [DisplayName("Sale To POI Data")]
    [IsoXmlTag("SaleToPOIData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToPOIData { get; init; }

    /// <summary>
    /// Sale information intended for the Acquirer.
    /// </summary>
    [IsoId("_kR1SxIYEEemxIqbaFEE8-w")]
    [DisplayName("Sale To Acquirer Data")]
    [IsoXmlTag("SaleToAcqrrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToAcquirerData { get; init; }

    /// <summary>
    /// Sale information intended for the Issuer.
    /// </summary>
    [IsoId("_kR1SxYYEEemxIqbaFEE8-w")]
    [DisplayName("Sale To Issuer Data")]
    [IsoXmlTag("SaleToIssrData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SaleToIssuerData { get; init; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sale context in which the transaction is performed.
/// </summary>
[IsoId("_nfzgYdwrEeioifFt1dhnJA")]
[DisplayName("Sale Context")]
public record SaleContext3
{
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_npKQsdwrEeioifFt1dhnJA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_npKQs9wrEeioifFt1dhnJA")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_npKQtdwrEeioifFt1dhnJA")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_npKQt9wrEeioifFt1dhnJA")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Languages used by the cashier.
    /// </summary>
    [IsoId("_xlqWENwrEeioifFt1dhnJA")]
    [DisplayName("Cashier Language")]
    [IsoXmlTag("CshrLang")]
    public SimpleValueList<LanguageCode> CashierLanguage { get; init; } = [];

    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_npKQudwrEeioifFt1dhnJA")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Flag indicating that list of CustomerOrders should be returned in response.
    /// </summary>
    [IsoId("_JIAmENwsEeioifFt1dhnJA")]
    [DisplayName("Customer Order Request Flag")]
    [IsoXmlTag("CstmrOrdrReqFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerOrderRequestFlag { get; init; }

    /// <summary>
    /// Identification of the purchase order.
    /// </summary>
    [IsoId("_npKQu9wrEeioifFt1dhnJA")]
    [DisplayName("Purchase Order Number")]
    [IsoXmlTag("PurchsOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PurchaseOrderNumber { get; init; }

    /// <summary>
    /// Identification of the invoice.
    /// </summary>
    [IsoId("_npKQvdwrEeioifFt1dhnJA")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Identification allocated by the sale system and given to the customer.
    /// </summary>
    [IsoId("_npKQv9wrEeioifFt1dhnJA")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryNoteNumber { get; init; }

    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    [IsoId("_npKQwdwrEeioifFt1dhnJA")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public ValueList<Organisation26> SponsoredMerchant { get; init; } = [];

    /// <summary>
    /// True if the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_npKQw9wrEeioifFt1dhnJA")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Remaining amount to complete the sale transaction, if a partial payment has been completed for the sale transaction.
    /// </summary>
    [IsoId("_npKQxdwrEeioifFt1dhnJA")]
    [DisplayName("Remaining Amount")]
    [IsoXmlTag("RmngAmt")]
    public ImpliedCurrencyAndAmount? RemainingAmount { get; init; }

    /// <summary>
    /// Indicates if the Cashier requires POI forces online access to the Acquirer.
    /// </summary>
    [IsoId("_STO_gNwsEeioifFt1dhnJA")]
    [DisplayName("Force Online Flag")]
    [IsoXmlTag("ForceOnlnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ForceOnlineFlag { get; init; }

    /// <summary>
    /// Indicates if the card data has to be taken from a previous transaction.
    /// </summary>
    [IsoId("_WlbNcNwsEeioifFt1dhnJA")]
    [DisplayName("Reuse Card Data Flag")]
    [IsoXmlTag("ReuseCardDataFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReuseCardDataFlag { get; init; }

    /// <summary>
    /// Type of card data reading.
    /// </summary>
    [IsoId("_aSPdcNwsEeioifFt1dhnJA")]
    [DisplayName("Allowed Entry Mode")]
    [IsoXmlTag("AllwdNtryMd")]
    public SimpleValueList<CardDataReading6Code> AllowedEntryMode { get; init; } = [];

    /// <summary>
    /// Scope of the token that identifies the payment mean of the customer.
    /// </summary>
    [IsoId("_eCfb8NwsEeioifFt1dhnJA")]
    [DisplayName("Sale Token Scope")]
    [IsoXmlTag("SaleTknScp")]
    public SaleTokenScope1Code? SaleTokenScope { get; init; }

    /// <summary>
    /// Additional information associated with the sale transaction.
    /// </summary>
    [IsoId("_npKQx9wrEeioifFt1dhnJA")]
    [DisplayName("Additional Sale Data")]
    [IsoXmlTag("AddtlSaleData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalSaleData { get; init; }
}

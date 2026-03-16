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
[IsoId("_1piOoY0VEeWRYffwL7E13A")]
[DisplayName("Sale Context")]
public record SaleContext2
{
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_1z99AY0VEeWRYffwL7E13A")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_1z99A40VEeWRYffwL7E13A")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_1z99BY0VEeWRYffwL7E13A")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_1z99B40VEeWRYffwL7E13A")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_1z99CY0VEeWRYffwL7E13A")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Identification of the purchase order.
    /// </summary>
    [IsoId("_m9lbcJXEEeWr_-S5OCtcIg")]
    [DisplayName("Purchase Order Number")]
    [IsoXmlTag("PurchsOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PurchaseOrderNumber { get; init; }

    /// <summary>
    /// Identification of the invoice.
    /// </summary>
    [IsoId("_sp3BwJXEEeWr_-S5OCtcIg")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Identification allocated by the sale system and given to the customer.
    /// </summary>
    [IsoId("_zm_zAJXEEeWr_-S5OCtcIg")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryNoteNumber { get; init; }

    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    [IsoId("_93rfUI0WEeWRYffwL7E13A")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public Organisation26? SponsoredMerchant { get; init; }

    /// <summary>
    /// True if the payment transaction is a partial payment of the sale transaction.
    /// </summary>
    [IsoId("_HCLgAI0XEeWRYffwL7E13A")]
    [DisplayName("Split Payment")]
    [IsoXmlTag("SpltPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SplitPayment { get; init; }

    /// <summary>
    /// Remaining amount to complete the sale transaction, if a partial payment has been completed for the sale transaction.
    /// </summary>
    [IsoId("_L-uSgI0XEeWRYffwL7E13A")]
    [DisplayName("Remaining Amount")]
    [IsoXmlTag("RmngAmt")]
    public ImpliedCurrencyAndAmount? RemainingAmount { get; init; }

    /// <summary>
    /// Additional information associated with the sale transaction.
    /// </summary>
    [IsoId("_1z99C40VEeWRYffwL7E13A")]
    [DisplayName("Additional Sale Data")]
    [IsoXmlTag("AddtlSaleData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalSaleData { get; init; }
}

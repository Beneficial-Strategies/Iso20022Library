// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the Sale to POI Reconciliation processing.
/// </summary>
[IsoId("_93n5UNxfEeioifFt1dhnJA")]
[DisplayName("Transaction Totals Set")]
public record TransactionTotalsSet1
{
    /// <summary>
    /// Type of payment instrument.
    /// </summary>
    [IsoId("_KVLmMNxgEeioifFt1dhnJA")]
    [DisplayName("Payment Instrument Type")]
    [IsoXmlTag("PmtInstrmTp")]
    public required PaymentInstrumentType1Code PaymentInstrumentType { get; init; }

    /// <summary>
    /// Identification of an Acquirer.
    /// </summary>
    [IsoId("_pIKLMNxgEeioifFt1dhnJA")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identifier of a host reconciliation period: acquirer for a payment or server for loyalty.
    /// </summary>
    [IsoId("_0hroMNxgEeioifFt1dhnJA")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Identifier of a reconciliation period on the sale system.
    /// </summary>
    [IsoId("__uiiMNxgEeioifFt1dhnJA")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Brand of payment card or loyalty system.
    /// </summary>
    [IsoId("_DHNuMNxhEeioifFt1dhnJA")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Identifier of the POI system performing a reconciliation.
    /// </summary>
    [IsoId("_G9gDQNxhEeioifFt1dhnJA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_KhixwNxhEeioifFt1dhnJA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Identification of the cashier who carried out the transactions.
    /// </summary>
    [IsoId("_Od2PQNxhEeioifFt1dhnJA")]
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_RQcSsNxhEeioifFt1dhnJA")]
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    [IsoId("_W-gowNxhEeioifFt1dhnJA")]
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public Organisation26? SponsoredMerchant { get; init; }

    /// <summary>
    /// Payment Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    [IsoId("_UIs5QNxhEeioifFt1dhnJA")]
    [DisplayName("Transaction Total")]
    [IsoXmlTag("TxTtl")]
    public required TransactionTotals8 TransactionTotal { get; init; }

    /// <summary>
    /// Loyalty Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    [IsoId("_WAtHQNxiEeioifFt1dhnJA")]
    [DisplayName("Loyalty Transaction Total")]
    [IsoXmlTag("LltyTxTtl")]
    public LoyaltyTransactionTotals1? LoyaltyTransactionTotal { get; init; }
}

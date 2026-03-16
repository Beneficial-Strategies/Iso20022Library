// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Totals Set2.
/// </summary>
[IsoId("_7yAJQZ9XEe-nbM0aSPcoiQ")]
[DisplayName("Transaction Totals Set2")]
public record TransactionTotalsSet2
{
    /// <summary>
    /// Acquirer Identification.
    /// </summary>
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public IsoMax35Text? AcquirerIdentification { get; init; }

    /// <summary>
    /// Brand.
    /// </summary>
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Cashier Identification.
    /// </summary>
    [DisplayName("Cashier Identification")]
    [IsoXmlTag("CshrId")]
    public IsoMax35Text? CashierIdentification { get; init; }

    /// <summary>
    /// Loyalty Transaction Total.
    /// </summary>
    [DisplayName("Loyalty Transaction Total")]
    [IsoXmlTag("LltyTxTtl")]
    public ValueList<LoyaltyTransactionTotals1> LoyaltyTransactionTotal { get; init; } = [];

    /// <summary>
    /// Payment Instrument Type.
    /// </summary>
    [DisplayName("Payment Instrument Type")]
    [IsoXmlTag("PmtInstrmTp")]
    public required PaymentInstrumentType2Code PaymentInstrumentType { get; init; }

    /// <summary>
    /// POI Identification.
    /// </summary>
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public IsoMax35Text? POIIdentification { get; init; }

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Sale Identification.
    /// </summary>
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Sale Reconciliation Identification.
    /// </summary>
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Shift Number.
    /// </summary>
    [DisplayName("Shift Number")]
    [IsoXmlTag("ShftNb")]
    public IsoMax2NumericText? ShiftNumber { get; init; }

    /// <summary>
    /// Sponsored Merchant.
    /// </summary>
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public ValueList<Organisation26> SponsoredMerchant { get; init; } = [];

    /// <summary>
    /// Transaction Total.
    /// </summary>
    [DisplayName("Transaction Total")]
    [IsoXmlTag("TxTtl")]
    public required TransactionTotals8 TransactionTotal { get; init; }
}

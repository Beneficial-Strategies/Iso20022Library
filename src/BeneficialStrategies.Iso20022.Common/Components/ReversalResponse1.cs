// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Data to a Reversal request.
/// </summary>
[IsoId("_cW7AQNxTEeioifFt1dhnJA")]
[DisplayName("Reversal Response")]
public record ReversalResponse1
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_dbzJle2qEei-V5h0ja04AA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_dbzJlu2qEei-V5h0ja04AA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_dbzJl-2qEei-V5h0ja04AA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_dbzJmO2qEei-V5h0ja04AA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_dbzwoO2qEei-V5h0ja04AA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_l5VxsNxTEeioifFt1dhnJA")]
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult1 ReversalTransactionResult { get; init; }

    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_CS-gwNxUEeioifFt1dhnJA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_GbkGwNxUEeioifFt1dhnJA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt1> Receipt { get; init; } = [];
}

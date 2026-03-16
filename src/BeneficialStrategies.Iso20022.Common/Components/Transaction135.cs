// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation transaction
/// </summary>
[IsoId("_onnzYYv9EeuC5632vxUfGg")]
[DisplayName("Transaction")]
public record Transaction135
{
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_otJMkYv9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Function")]
    [IsoXmlTag("RcncltnFctn")]
    public required ReconciliationFunction1Code ReconciliationFunction { get; init; }

    /// <summary>
    /// A code to indicate the activity type to be reconciled.
    /// </summary>
    [IsoId("_EYGlACX_Eeym0KcvJF9aDQ")]
    [DisplayName("Reconciliation Activity Type")]
    [IsoXmlTag("RcncltnActvtyTp")]
    public ReconciliationActivityType1Code? ReconciliationActivityType { get; init; }

    /// <summary>
    /// Other reconciliation activity type defined at private or national level
    /// </summary>
    [IsoId("_MDkJ8CYBEeym0KcvJF9aDQ")]
    [DisplayName("Other Reconciliation Activity Type")]
    [IsoXmlTag("OthrRcncltnActvtyTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherReconciliationActivityType { get; init; }

    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_otJMk4v9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Type")]
    [IsoXmlTag("RcncltnTp")]
    public required CardServiceType4Code ReconciliationType { get; init; }

    /// <summary>
    /// Other type of reconciliation.
    /// </summary>
    [IsoId("_otJMlYv9EeuC5632vxUfGg")]
    [DisplayName("Other Reconciliation Type")]
    [IsoXmlTag("OthrRcncltnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherReconciliationType { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_otJMl4v9EeuC5632vxUfGg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification12? TransactionIdentification { get; init; }

    /// <summary>
    /// Requested currency by the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_otJMmYv9EeuC5632vxUfGg")]
    [DisplayName("Requested Currency")]
    [IsoXmlTag("ReqdCcy")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? RequestedCurrency { get; init; }

    /// <summary>
    /// Totals of the reconciliation.
    /// </summary>
    [IsoId("_otJMm4v9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Totals")]
    [IsoXmlTag("RcncltnTtls")]
    public TransactionTotals13? ReconciliationTotals { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_otJzoYv9EeuC5632vxUfGg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_otJzo4v9EeuC5632vxUfGg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}

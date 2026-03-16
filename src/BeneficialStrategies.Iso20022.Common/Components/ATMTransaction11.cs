// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the reconciliation request.
/// </summary>
[IsoId("_hM43sYtxEeSLQutgI1Ulfw")]
[DisplayName("ATM Transaction")]
public record ATMTransaction11
{
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_Q0orUOhBEeSbwP3G-MV9YA")]
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation1Code? TypeOfOperation { get; init; }

    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_7m03UOqREeSYnL2yvgmxmw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    [IsoId("_7j-qwItyEeSLQutgI1Ulfw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; }

    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_hZja1YtxEeSLQutgI1Ulfw")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ATMTotals1? ATMTotals { get; init; }

    /// <summary>
    /// Information on the cassette of the ATM.
    /// </summary>
    [IsoId("_hZja14txEeSLQutgI1Ulfw")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ATMCassette1? Cassette { get; init; }

    /// <summary>
    /// Transaction counters that are set to zero after a reconciliation with counter reinitialisation command.
    /// </summary>
    [IsoId("_JH7X8ItzEeSLQutgI1Ulfw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ATMTotals3? TransactionTotals { get; init; }

    /// <summary>
    /// Total number of retained cards.
    /// </summary>
    [IsoId("_zBBVwItzEeSLQutgI1Ulfw")]
    [DisplayName("Retained Card")]
    [IsoXmlTag("RtndCard")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RetainedCard { get; init; }

    /// <summary>
    /// Additional information about reconciliation.
    /// </summary>
    [IsoId("_3eiC4ItzEeSLQutgI1Ulfw")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalTransactionInformation { get; init; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Reconciliation Operation1.
/// </summary>
[IsoId("_y2c5kJ2hEe-4seDr3Li2Ew")]
[DisplayName("ATM Reconciliation Operation1")]
public record ATMReconciliationOperation1
{
    /// <summary>
    /// Additional Transaction Information.
    /// </summary>
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    public IsoMax140Text? AdditionalTransactionInformation { get; init; }

    /// <summary>
    /// ATM Totals.
    /// </summary>
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ValueList<ATMTotals4> ATMTotals { get; init; } = [];

    /// <summary>
    /// Cassette.
    /// </summary>
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette3> Cassette { get; init; } = [];

    /// <summary>
    /// Incident.
    /// </summary>
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public ValueList<FailureReason9Code> Incident { get; init; } = [];

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public required IsoMax35Text ReconciliationIdentification { get; init; }

    /// <summary>
    /// Retained Card.
    /// </summary>
    [DisplayName("Retained Card")]
    [IsoXmlTag("RtndCard")]
    public IsoNumber? RetainedCard { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Totals.
    /// </summary>
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<ATMTotals3> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Type Of Operation.
    /// </summary>
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation2Code? TypeOfOperation { get; init; }
}

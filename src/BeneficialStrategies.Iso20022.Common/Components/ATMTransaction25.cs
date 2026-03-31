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
[IsoId("_DiZz4a48EeWRfYPBaeOY8w")]
[DisplayName("ATM Transaction")]
public record ATMTransaction25
{
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_DtSOMa48EeWRfYPBaeOY8w")]
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation1Code? TypeOfOperation { get; init; }

    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_DtSOM648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    [IsoId("_DtSONa48EeWRfYPBaeOY8w")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; }

    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_DtSON648EeWRfYPBaeOY8w")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ValueList<ATMTotals1> ATMTotals { get; init; } = [];

    /// <summary>
    /// Information on the cassette of the ATM.
    /// </summary>
    [IsoId("_DtSOOa48EeWRfYPBaeOY8w")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette2> Cassette { get; init; } = [];

    /// <summary>
    /// Transaction counters that are set to zero after a reconciliation with counter reinitialisation command.
    /// </summary>
    [IsoId("_DtSOO648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<ATMTotals3> TransactionTotals { get; init; } = [];

    /// <summary>
    /// Total number of retained cards.
    /// </summary>
    [IsoId("_DtSOPa48EeWRfYPBaeOY8w")]
    [DisplayName("Retained Card")]
    [IsoXmlTag("RtndCard")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RetainedCard { get; init; }

    /// <summary>
    /// Additional information about reconciliation.
    /// </summary>
    [IsoId("_DtSOP648EeWRfYPBaeOY8w")]
    [DisplayName("Additional Transaction Information")]
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalTransactionInformation { get; init; }
}

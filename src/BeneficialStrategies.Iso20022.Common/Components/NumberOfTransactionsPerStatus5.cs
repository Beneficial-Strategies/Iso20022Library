// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_-qEw2ZRuEeazAtAtDSg0Nw")]
[DisplayName("Number Of Transactions Per Status")]
public record NumberOfTransactionsPerStatus5
{
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_-1rj05RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; }

    /// <summary>
    /// Common transaction status for all individual transactions reported.
    /// </summary>
    [IsoId("_-1rj1ZRuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required ExternalPaymentTransactionStatus1Code DetailedStatus { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_-1rj15RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; }
}

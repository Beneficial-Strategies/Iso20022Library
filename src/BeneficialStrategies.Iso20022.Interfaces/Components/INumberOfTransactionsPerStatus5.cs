// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_-qEw2ZRuEeazAtAtDSg0Nw")]
public interface INumberOfTransactionsPerStatus5 : IIsoComponent
{
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_-1rj05RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    Max15NumericText DetailedNumberOfTransactions { get; }

    /// <summary>
    /// Common transaction status for all individual transactions reported.
    /// </summary>
    [IsoId("_-1rj1ZRuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    ExternalPaymentTransactionStatus1Code DetailedStatus { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_-1rj15RuEeazAtAtDSg0Nw")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    DecimalNumber? DetailedControlSum { get; }
}

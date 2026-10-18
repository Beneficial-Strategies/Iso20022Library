// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of additional elements to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_RFBsa9p-Ed-ak6NoX_4Aeg_187558079")]
public interface INumberOfTransactionsPerStatus1 : IIsoComponent
{
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_RFBsbNp-Ed-ak6NoX_4Aeg_1091683583")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    IsoMax15NumericText DetailedNumberOfTransactions { get; }

    /// <summary>
    /// Common transaction status for all individual transactions reported with the same status.
    /// </summary>
    [IsoId("_RFBsbdp-Ed-ak6NoX_4Aeg_1140631688")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    TransactionIndividualStatus1Code DetailedStatus { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_RFLdYNp-Ed-ak6NoX_4Aeg_-1896383471")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    IsoDecimalNumber? DetailedControlSum { get; }
}

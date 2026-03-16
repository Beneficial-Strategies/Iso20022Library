// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of additional elements to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_RFBsa9p-Ed-ak6NoX_4Aeg_187558079")]
[DisplayName("Number Of Transactions Per Status")]
public record NumberOfTransactionsPerStatus1
{
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_RFBsbNp-Ed-ak6NoX_4Aeg_1091683583")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; }

    /// <summary>
    /// Common transaction status for all individual transactions reported with the same status.
    /// </summary>
    [IsoId("_RFBsbdp-Ed-ak6NoX_4Aeg_1140631688")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required TransactionIndividualStatus1Code DetailedStatus { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_RFLdYNp-Ed-ak6NoX_4Aeg_-1896383471")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; }
}

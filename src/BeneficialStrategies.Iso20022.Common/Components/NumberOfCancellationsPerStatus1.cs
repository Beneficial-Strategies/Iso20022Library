// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific cancellation status.
/// </summary>
[IsoId("_Rquaddp-Ed-ak6NoX_4Aeg_847606645")]
[DisplayName("Number Of Cancellations Per Status")]
public record NumberOfCancellationsPerStatus1
{
    /// <summary>
    /// Number of individual cancellation requests contained in the message, detailed per status.
    /// </summary>
    [IsoId("_Rquadtp-Ed-ak6NoX_4Aeg_847606677")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; }

    /// <summary>
    /// Common cancellation request status for all individual cancellation requests reported.
    /// </summary>
    [IsoId("_Rquad9p-Ed-ak6NoX_4Aeg_847606923")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required CancellationIndividualStatus1Code DetailedStatus { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_RquaeNp-Ed-ak6NoX_4Aeg_847606954")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; }
}

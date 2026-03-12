// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of additional elements to provide detailed information on the number of transactions that are reported with a specific transaction status.
/// </summary>
[IsoId("_WG5Dy9p-Ed-ak6NoX_4Aeg_-496011907")]
[DisplayName("Number Of Transactions Per Status")]
public partial record NumberOfTransactionsPerStatus2
{
    #nullable enable
    
    /// <summary>
    /// Number of individual transactions contained in the message, detailed per status.
    /// </summary>
    [IsoId("_WG5DzNp-Ed-ak6NoX_4Aeg_-496011864")]
    [DisplayName("Detailed Number Of Transactions")]
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Common transaction status for all individual transactions reported with the same status.
    /// </summary>
    [IsoId("_WG5Dzdp-Ed-ak6NoX_4Aeg_-496011546")]
    [DisplayName("Detailed Status")]
    [IsoXmlTag("DtldSts")]
    public required TransactionIndividualStatus2Code DetailedStatus { get; init; } 
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_WG5Dztp-Ed-ak6NoX_4Aeg_-496011461")]
    [DisplayName("Detailed Control Sum")]
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? DetailedControlSum { get; init; } 
    
    
    #nullable disable
    
}

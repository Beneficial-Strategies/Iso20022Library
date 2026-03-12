// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the total sum of entries per bank transaction code.
/// </summary>
[IsoId("_xkvGwaRgEeeKoo4sGOxgwA")]
[DisplayName("Totals Per Bank Transaction Code")]
public partial record TotalsPerBankTransactionCode5
{
    #nullable enable
    
    /// <summary>
    /// Number of individual entries for the bank transaction code.
    /// </summary>
    [IsoId("_xwGpQ6RgEeeKoo4sGOxgwA")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_xwGpRaRgEeeKoo4sGOxgwA")]
    [DisplayName("Sum")]
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Sum { get; init; } 
    
    /// <summary>
    /// Total debit or credit amount that is the result of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_xwGpR6RgEeeKoo4sGOxgwA")]
    [DisplayName("Total Net Entry")]
    [IsoXmlTag("TtlNetNtry")]
    public AmountAndDirection35? TotalNetEntry { get; init; } 
    
    /// <summary>
    /// Number of individual credit entries for the bank transaction code.
    /// </summary>
    [IsoId("__32nEaRgEeeKoo4sGOxgwA")]
    [DisplayName("Credit Entries")]
    [IsoXmlTag("CdtNtries")]
    public NumberAndSumOfTransactions1? CreditEntries { get; init; } 
    
    /// <summary>
    /// Number of individual debit entries for the bank transaction code.
    /// </summary>
    [IsoId("__YYc0aRgEeeKoo4sGOxgwA")]
    [DisplayName("Debit Entries")]
    [IsoXmlTag("DbtNtries")]
    public NumberAndSumOfTransactions1? DebitEntries { get; init; } 
    
    /// <summary>
    /// Indicates whether the bank transaction code is related to booked or forecast items.
    /// </summary>
    [IsoId("_xwGpSaRgEeeKoo4sGOxgwA")]
    [DisplayName("Forecast Indicator")]
    [IsoXmlTag("FcstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ForecastIndicator { get; init; } 
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_xwGpS6RgEeeKoo4sGOxgwA")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.
    /// </summary>
    [IsoId("_xwGpTaRgEeeKoo4sGOxgwA")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashAvailability1? Availability { get; init; } 
    
    /// <summary>
    /// Indicates the date (and time) of the transaction summary.
    /// </summary>
    [IsoId("_0TZFYaRgEeeKoo4sGOxgwA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; } 
    
    
    #nullable disable
    
}

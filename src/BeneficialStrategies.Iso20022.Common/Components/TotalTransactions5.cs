// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide summary information on entries.
/// </summary>
[IsoId("_VKlh0TqwEeWZFYSPlduMhw")]
[DisplayName("Total Transactions")]
public partial record TotalTransactions5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_VRvSkTqwEeWZFYSPlduMhw")]
    [DisplayName("Total Entries")]
    [IsoXmlTag("TtlNtries")]
    public NumberAndSumOfTransactions4? TotalEntries { get; init; } 
    
    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_VRvSkzqwEeWZFYSPlduMhw")]
    [DisplayName("Total Credit Entries")]
    [IsoXmlTag("TtlCdtNtries")]
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    
    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_VRvSlTqwEeWZFYSPlduMhw")]
    [DisplayName("Total Debit Entries")]
    [IsoXmlTag("TtlDbtNtries")]
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    
    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_VRvSlzqwEeWZFYSPlduMhw")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    public TotalsPerBankTransactionCode4? TotalEntriesPerBankTransactionCode { get; init; } 
    
    
    #nullable disable
    
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide summary information on entries.
/// </summary>
[IsoId("_VKlh0TqwEeWZFYSPlduMhw")]
[DisplayName("Total Transactions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalTransactions5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the total number and sum of debit and credit entries.
    /// </summary>
    [IsoId("_VRvSkTqwEeWZFYSPlduMhw")]
    [DisplayName("Total Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNtries")]
    #endif
    [IsoXmlTag("TtlNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions4? TotalEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions4? TotalEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions4? TotalEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of credit entries.
    /// </summary>
    [IsoId("_VRvSkzqwEeWZFYSPlduMhw")]
    [DisplayName("Total Credit Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCdtNtries")]
    #endif
    [IsoXmlTag("TtlCdtNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions1? TotalCreditEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of debit entries.
    /// </summary>
    [IsoId("_VRvSlTqwEeWZFYSPlduMhw")]
    [DisplayName("Total Debit Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDbtNtries")]
    #endif
    [IsoXmlTag("TtlDbtNtries")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; init; } 
    #else
    public NumberAndSumOfTransactions1? TotalDebitEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the total number and sum of entries per bank transaction code.
    /// </summary>
    [IsoId("_VRvSlzqwEeWZFYSPlduMhw")]
    [DisplayName("Total Entries Per Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNtriesPerBkTxCd")]
    #endif
    [IsoXmlTag("TtlNtriesPerBkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalsPerBankTransactionCode4? TotalEntriesPerBankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalsPerBankTransactionCode4? TotalEntriesPerBankTransactionCode { get; init; } 
    #else
    public TotalsPerBankTransactionCode4? TotalEntriesPerBankTransactionCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}

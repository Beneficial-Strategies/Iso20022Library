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
/// Set of elements providing the total sum of entries per bank transaction code.
/// </summary>
[IsoId("_RU-M49p-Ed-ak6NoX_4Aeg_-1159458700")]
[DisplayName("Number And Sum Of Transactions Per Bank Transaction Code")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberAndSumOfTransactionsPerBankTransactionCode1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberAndSumOfTransactionsPerBankTransactionCode1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberAndSumOfTransactionsPerBankTransactionCode1( BankTransactionCodeStructure1 reqBankTransactionCode )
    {
        BankTransactionCode = reqBankTransactionCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual entries contained in the report.
    /// </summary>
    [IsoId("_RU-M5Np-Ed-ak6NoX_4Aeg_-1158538669")]
    [DisplayName("Number Of Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfNtries")]
    #endif
    [IsoXmlTag("NbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfEntries { get; init; } 
    #else
    public System.String? NumberOfEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual entries included in the report.
    /// </summary>
    [IsoId("_RU-M5dp-Ed-ak6NoX_4Aeg_-1158538591")]
    [DisplayName("Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sum")]
    #endif
    [IsoXmlTag("Sum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Sum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Sum { get; init; } 
    #else
    public System.UInt64? Sum { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting amount of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_RU-M5tp-Ed-ak6NoX_4Aeg_1319749819")]
    [DisplayName("Total Net Entry Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNetNtryAmt")]
    #endif
    [IsoXmlTag("TtlNetNtryAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalNetEntryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNetEntryAmount { get; init; } 
    #else
    public System.UInt64? TotalNetEntryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the total net entry amount is a credit or a debit amount.
    /// </summary>
    [IsoId("_RU-M59p-Ed-ak6NoX_4Aeg_-223720667")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_RU-M6Np-Ed-ak6NoX_4Aeg_434460822")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure1 BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure1 BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest.
    /// </summary>
    [IsoId("_RVH94Np-Ed-ak6NoX_4Aeg_1922475023")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceAvailability1? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceAvailability1? Availability { get; init; } 
    #else
    public CashBalanceAvailability1? Availability { get; set; } 
    #endif
    
    
    #nullable disable
    
}

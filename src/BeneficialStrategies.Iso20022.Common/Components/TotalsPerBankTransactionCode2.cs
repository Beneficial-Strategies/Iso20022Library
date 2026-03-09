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
/// Set of elements used to provide the total sum of entries per bank transaction code.
/// </summary>
[IsoId("_RpY9tdp-Ed-ak6NoX_4Aeg_-609547730")]
[DisplayName("Totals Per Bank Transaction Code")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalsPerBankTransactionCode2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalsPerBankTransactionCode2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalsPerBankTransactionCode2( BankTransactionCodeStructure4 reqBankTransactionCode )
    {
        BankTransactionCode = reqBankTransactionCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual entries for the bank transaction code.
    /// </summary>
    [IsoId("_RpY9ttp-Ed-ak6NoX_4Aeg_-609547699")]
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
    [IsoId("_RpY9t9p-Ed-ak6NoX_4Aeg_-609547668")]
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
    /// Total amount that is the result of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_RpY9uNp-Ed-ak6NoX_4Aeg_-609547359")]
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
    [IsoId("_RpY9udp-Ed-ak6NoX_4Aeg_-609547336")]
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
    /// Indicates whether the bank transaction code is related to booked or forecast items.
    /// </summary>
    [IsoId("_RpiHoNp-Ed-ak6NoX_4Aeg_-577224009")]
    [DisplayName("Forecast Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FcstInd")]
    #endif
    [IsoXmlTag("FcstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ForecastIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForecastIndicator { get; init; } 
    #else
    public System.String? ForecastIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to fully identify the type of underlying transaction resulting in an entry.
    /// </summary>
    [IsoId("_RpiHodp-Ed-ak6NoX_4Aeg_-609547243")]
    [DisplayName("Bank Transaction Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkTxCd")]
    #endif
    [IsoXmlTag("BkTxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BankTransactionCodeStructure4 BankTransactionCode { get; init; } 
    #else
    public BankTransactionCodeStructure4 BankTransactionCode { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, that is can be accessed and starts generating interest.
    /// </summary>
    [IsoId("_RpiHotp-Ed-ak6NoX_4Aeg_-609547181")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceAvailability2? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceAvailability2? Availability { get; init; } 
    #else
    public CashBalanceAvailability2? Availability { get; set; } 
    #endif
    
    
    #nullable disable
    
}

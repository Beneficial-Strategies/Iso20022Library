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
[IsoId("_VRvSmTqwEeWZFYSPlduMhw")]
[DisplayName("Totals Per Bank Transaction Code")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalsPerBankTransactionCode4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalsPerBankTransactionCode4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalsPerBankTransactionCode4( BankTransactionCodeStructure4 reqBankTransactionCode )
    {
        BankTransactionCode = reqBankTransactionCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual entries for the bank transaction code.
    /// </summary>
    [IsoId("_VYy80zqwEeWZFYSPlduMhw")]
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
    [IsoId("_VYy81TqwEeWZFYSPlduMhw")]
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
    /// Total debit or credit amount that is the result of the netted amounts for all debit and credit entries per bank transaction code.
    /// </summary>
    [IsoId("_VYy81zqwEeWZFYSPlduMhw")]
    [DisplayName("Total Net Entry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNetNtry")]
    #endif
    [IsoXmlTag("TtlNetNtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection35? TotalNetEntry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection35? TotalNetEntry { get; init; } 
    #else
    public AmountAndDirection35? TotalNetEntry { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the bank transaction code is related to booked or forecast items.
    /// </summary>
    [IsoId("_VYy82TqwEeWZFYSPlduMhw")]
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
    [IsoId("_VYy82zqwEeWZFYSPlduMhw")]
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
    [IsoId("_VYy83TqwEeWZFYSPlduMhw")]
    [DisplayName("Availability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Avlbty")]
    #endif
    [IsoXmlTag("Avlbty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAvailability1? Availability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAvailability1? Availability { get; init; } 
    #else
    public CashAvailability1? Availability { get; set; } 
    #endif
    
    
    #nullable disable
    
}

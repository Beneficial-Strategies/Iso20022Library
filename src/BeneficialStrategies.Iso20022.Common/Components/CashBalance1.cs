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
/// Set of elements defining the balance details.
/// </summary>
[IsoId("_SYLWU9p-Ed-ak6NoX_4Aeg_-1921961120")]
[DisplayName("Cash Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalance1( BalanceType1Choice_ reqType,CurrencyAndAmount reqAmount,CreditDebitCode reqCreditDebitIndicator,DateAndDateTimeChoice_ reqDate )
    {
        Type = reqType;
        Amount = reqAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of a balance, eg, opening booked balance.
    /// </summary>
    [IsoId("_SYLWVNp-Ed-ak6NoX_4Aeg_411546015")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType1Choice_ Type { get; init; } 
    #else
    public BalanceType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further details on the credit line information.
    /// </summary>
    [IsoId("_SYLWVdp-Ed-ak6NoX_4Aeg_577366369")]
    [DisplayName("Credit Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtLine")]
    #endif
    [IsoXmlTag("CdtLine")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditLine1? CreditLine { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditLine1? CreditLine { get; init; } 
    #else
    public CreditLine1? CreditLine { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    [IsoId("_SYLWVtp-Ed-ak6NoX_4Aeg_-1921961008")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_SYLWV9p-Ed-ak6NoX_4Aeg_-1921960682")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date (and time) of the balance.
    /// </summary>
    [IsoId("_SYLWWNp-Ed-ak6NoX_4Aeg_-1921960605")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ Date { get; init; } 
    #else
    public DateAndDateTimeChoice_ Date { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_SYLWWdp-Ed-ak6NoX_4Aeg_1099826436")]
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

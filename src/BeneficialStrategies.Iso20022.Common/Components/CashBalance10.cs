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
/// Balance details for a cash account.
/// </summary>
[IsoId("_fzY4IZ-WEee28J7y9KlTWg")]
[DisplayName("Cash Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalance10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalance10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalance10( ImpliedCurrencyAndAmount reqAmount,CreditDebitCode reqCreditDebitIndicator )
    {
        Amount = reqAmount;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    [IsoId("_f-mCk5-WEee28J7y9KlTWg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_f-mClZ-WEee28J7y9KlTWg")]
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
    /// Specifies the nature of a balance.
    /// </summary>
    [IsoId("_f-mCl5-WEee28J7y9KlTWg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceType8Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType8Choice_? Type { get; init; } 
    #else
    public BalanceType8Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Current status of a cash balance.
    /// </summary>
    [IsoId("_f-mCmZ-WEee28J7y9KlTWg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceStatus1Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceStatus1Code? Status { get; init; } 
    #else
    public BalanceStatus1Code? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the balance is or will be available.
    /// </summary>
    [IsoId("_f-mCm5-WEee28J7y9KlTWg")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of payments taken into account for the calculation of the cash balance value.
    /// </summary>
    [IsoId("_f-mCnZ-WEee28J7y9KlTWg")]
    [DisplayName("Number Of Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfPmts")]
    #endif
    [IsoXmlTag("NbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfPayments { get; init; } 
    #else
    public System.UInt64? NumberOfPayments { get; set; } 
    #endif
    
    /// <summary>
    /// Type providing further information on balance restrictions.
    /// </summary>
    [IsoId("_f-mCn5-WEee28J7y9KlTWg")]
    [DisplayName("Restriction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnTp")]
    #endif
    [IsoXmlTag("RstrctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceRestrictionType1? RestrictionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceRestrictionType1? RestrictionType { get; init; } 
    #else
    public BalanceRestrictionType1? RestrictionType { get; set; } 
    #endif
    
    
    #nullable disable
    
}

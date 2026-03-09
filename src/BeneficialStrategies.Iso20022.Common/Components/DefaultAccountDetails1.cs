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
/// Details about successor account for automated default funds transfer.
/// </summary>
[IsoId("_7rRPoCDmEeav65mEytrgaA")]
[DisplayName("Default Account Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DefaultAccountDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DefaultAccountDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DefaultAccountDetails1( FinancialInstitutionIdentification9 reqAccountOwner,CashAccount24 reqAccount )
    {
        AccountOwner = reqAccountOwner;
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account owner identification.
    /// </summary>
    [IsoId("_Q7KfYCDoEeav65mEytrgaA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    #else
    public FinancialInstitutionIdentification9 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account identification.
    /// </summary>
    [IsoId("_X8ZGcCDoEeav65mEytrgaA")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount24 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount24 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24 Account { get; init; } 
    #else
    public CashAccount24 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Information about time and event fund transfer.
    /// </summary>
    [IsoId("_kgosACc8Eea7avjfd7yDAA")]
    [DisplayName("Daily Fund Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DalyFndTrf")]
    #endif
    [IsoXmlTag("DalyFndTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DailyFundTransfer1Choice_? DailyFundTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DailyFundTransfer1Choice_? DailyFundTransfer { get; init; } 
    #else
    public DailyFundTransfer1Choice_? DailyFundTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}

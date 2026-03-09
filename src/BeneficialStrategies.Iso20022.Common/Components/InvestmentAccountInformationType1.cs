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
/// Select the type(s) of information to be retrieved about a registered investment account.
/// </summary>
[IsoId("_RR2AZNp-Ed-ak6NoX_4Aeg_1677189755")]
[DisplayName("Investment Account Information Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountInformationType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccountInformationType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccountInformationType1( System.String reqInvestmentAccount,System.String reqAccountParties,System.String reqIntermediaries,System.String reqInvestmentPlan,System.String reqCashSettlement,System.String reqServiceLevelAgreement )
    {
        InvestmentAccount = reqInvestmentAccount;
        AccountParties = reqAccountParties;
        Intermediaries = reqIntermediaries;
        InvestmentPlan = reqInvestmentPlan;
        CashSettlement = reqCashSettlement;
        ServiceLevelAgreement = reqServiceLevelAgreement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the core investment account information must be selected.
    /// </summary>
    [IsoId("_RR2AZdp-Ed-ak6NoX_4Aeg_1677190067")]
    [DisplayName("Investment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcct")]
    #endif
    [IsoXmlTag("InvstmtAcct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator InvestmentAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InvestmentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestmentAccount { get; init; } 
    #else
    public System.String InvestmentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the information about account parties must be selected.
    /// </summary>
    [IsoId("_RR2AZtp-Ed-ak6NoX_4Aeg_1677190092")]
    [DisplayName("Account Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPties")]
    #endif
    [IsoXmlTag("AcctPties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AccountParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountParties { get; init; } 
    #else
    public System.String AccountParties { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the information about the intermediaries must be selected.
    /// </summary>
    [IsoId("_RR2AZ9p-Ed-ak6NoX_4Aeg_1677190127")]
    [DisplayName("Intermediaries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmies")]
    #endif
    [IsoXmlTag("Intrmies")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Intermediaries { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Intermediaries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Intermediaries { get; init; } 
    #else
    public System.String Intermediaries { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the information about the investment plan(s) must be selected.
    /// </summary>
    [IsoId("_RR2AaNp-Ed-ak6NoX_4Aeg_1677190169")]
    [DisplayName("Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtPlan")]
    #endif
    [IsoXmlTag("InvstmtPlan")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator InvestmentPlan { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InvestmentPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InvestmentPlan { get; init; } 
    #else
    public System.String InvestmentPlan { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the cash settlement information must be selected.
    /// </summary>
    [IsoId("_RR2Aadp-Ed-ak6NoX_4Aeg_1677190470")]
    [DisplayName("Cash Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshSttlm")]
    #endif
    [IsoXmlTag("CshSttlm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CashSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CashSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CashSettlement { get; init; } 
    #else
    public System.String CashSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the Service Level Agreement information must be selected.
    /// </summary>
    [IsoId("_RR2Aatp-Ed-ak6NoX_4Aeg_1908994765")]
    [DisplayName("Service Level Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmt")]
    #endif
    [IsoXmlTag("SvcLvlAgrmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ServiceLevelAgreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ServiceLevelAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ServiceLevelAgreement { get; init; } 
    #else
    public System.String ServiceLevelAgreement { get; set; } 
    #endif
    
    
    #nullable disable
    
}

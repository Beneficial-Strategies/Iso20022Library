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
/// Account on which a securities entry is made.
/// </summary>
[IsoId("_0mLLh4jyEeONZKAAW4pOaQ")]
[DisplayName("Safekeeping Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingAccount5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingAccount5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingAccount5( SecuritiesAccount19 reqAccountIdentification,PartyIdentification100 reqAccountOwner,PartyIdentification100 reqAccountServicer )
    {
        AccountIdentification = reqAccountIdentification;
        AccountOwner = reqAccountOwner;
        AccountServicer = reqAccountServicer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_0mLLiojyEeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 AccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_0mLLi4jyEeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification100 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 AccountOwner { get; init; } 
    #else
    public PartyIdentification100 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_0mLLiYjyEeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification100 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 AccountServicer { get; init; } 
    #else
    public PartyIdentification100 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_7khGcKCHEeOEyO7fCl8lLA")]
    [DisplayName("Beneficial Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnr")]
    #endif
    [IsoXmlTag("BnfclOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    #else
    public BeneficialOwner2? BeneficialOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Report on the net position of a financial instrument, on the account, for a certain date.
    /// </summary>
    [IsoId("_0mLLjYjyEeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance1? BalanceForAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance1? BalanceForAccount { get; init; } 
    #else
    public AggregateHoldingBalance1? BalanceForAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent of the financial instrument, for example, the transfer agent.
    /// </summary>
    [IsoId("_ylQ_gYj5EeONZKAAW4pOaQ")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary28? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary28? Agent { get; init; } 
    #else
    public Intermediary28? Agent { get; set; } 
    #endif
    
    /// <summary>
    /// Holdings of level 1.
    /// </summary>
    [IsoId("_0mLLjIjyEeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl1")]
    #endif
    [IsoXmlTag("AcctSubLvl1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountSubLevel1? AccountSubLevel1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSubLevel1? AccountSubLevel1 { get; init; } 
    #else
    public AccountSubLevel1? AccountSubLevel1 { get; set; } 
    #endif
    
    /// <summary>
    /// Difference in holdings between the safekeeping account and the sub-accounts of level 1.
    /// </summary>
    [IsoId("_7YCN0aCAEeOEyO7fCl8lLA")]
    [DisplayName("Account Sub Level 1 Difference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl1Diff")]
    #endif
    [IsoXmlTag("AcctSubLvl1Diff")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance2? AccountSubLevel1Difference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance2? AccountSubLevel1Difference { get; init; } 
    #else
    public AggregateHoldingBalance2? AccountSubLevel1Difference { get; set; } 
    #endif
    
    
    #nullable disable
    
}

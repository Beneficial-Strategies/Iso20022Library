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
/// Account and holding of the next sub-level (Level 8).
/// </summary>
[IsoId("_iRD7MVjCEea1XpTdyimpLA")]
[DisplayName("Account Sub Level")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSubLevel18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountSubLevel18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSubLevel18( SecuritiesAccount19 reqAccountIdentification,PartyIdentification100 reqAccountOwner,PartyIdentification100 reqAccountServicer )
    {
        AccountIdentification = reqAccountIdentification;
        AccountOwner = reqAccountOwner;
        AccountServicer = reqAccountServicer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_iqpf4VjCEea1XpTdyimpLA")]
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
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_iqpf41jCEea1XpTdyimpLA")]
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
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_iqpf5VjCEea1XpTdyimpLA")]
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
    [IsoId("_iqpf51jCEea1XpTdyimpLA")]
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
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 8), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_lMg_sVjCEea1XpTdyimpLA")]
    [DisplayName("Balance Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalDtls")]
    #endif
    [IsoXmlTag("BalDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    #else
    public AggregateHoldingBalance3? BalanceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Holdings of level 9.
    /// </summary>
    [IsoId("_iqpf61jCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl9")]
    #endif
    [IsoXmlTag("AcctSubLvl9")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountSubLevel19? AccountSubLevel9 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSubLevel19? AccountSubLevel9 { get; init; } 
    #else
    public AccountSubLevel19? AccountSubLevel9 { get; set; } 
    #endif
    
    /// <summary>
    /// Difference in holdings between the sub-account at level 8 and the sub-accounts of level 9.
    /// </summary>
    [IsoId("_iqpf7VjCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level 9 Difference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl9Diff")]
    #endif
    [IsoXmlTag("AcctSubLvl9Diff")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance2? AccountSubLevel9Difference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance2? AccountSubLevel9Difference { get; init; } 
    #else
    public AggregateHoldingBalance2? AccountSubLevel9Difference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_iqpf8VjCEea1XpTdyimpLA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}

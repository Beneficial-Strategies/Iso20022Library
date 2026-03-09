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
/// Account and holding of the next sub-level (Level 7).
/// </summary>
[IsoId("_Lnjfp4j3EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountSubLevel7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountSubLevel7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountSubLevel7( SecuritiesAccount19 reqAccountIdentification,PartyIdentification100 reqAccountOwner,PartyIdentification100 reqAccountServicer )
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
    [IsoId("_Lnjfq4j3EeONZKAAW4pOaQ")]
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
    [IsoId("_LnjfqYj3EeONZKAAW4pOaQ")]
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
    [IsoId("_LnjfrYj3EeONZKAAW4pOaQ")]
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
    [IsoId("_0mPZoTyvEeSBD_ZW60GwCQ")]
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
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_LnjfqIj3EeONZKAAW4pOaQ")]
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
    /// Holdings of level 8.
    /// </summary>
    [IsoId("_LnjfrIj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl8")]
    #endif
    [IsoXmlTag("AcctSubLvl8")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountSubLevel8? AccountSubLevel8 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountSubLevel8? AccountSubLevel8 { get; init; } 
    #else
    public AccountSubLevel8? AccountSubLevel8 { get; set; } 
    #endif
    
    /// <summary>
    /// Difference in holdings between the sub-account at level 7 and the sub-accounts of level 8.
    /// </summary>
    [IsoId("_Lnjfqoj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 8 Difference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSubLvl8Diff")]
    #endif
    [IsoXmlTag("AcctSubLvl8Diff")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; init; } 
    #else
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_MWbMIb3OEeO2FLWuu_JIqg")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary29? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary29? Agent { get; init; } 
    #else
    public Intermediary29? Agent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_PESbIW5HEeSFHPWGV34yZw")]
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

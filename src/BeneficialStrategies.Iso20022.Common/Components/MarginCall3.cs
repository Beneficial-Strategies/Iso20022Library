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
/// Specifies the calculation and the resulting margin and independent amount needed to cover the risk exposure of one party versus another.
/// </summary>
[IsoId("_xPT9kSqQEeyR9JrVGfaMKw")]
[DisplayName("Margin Call")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCall3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCall3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCall3( MarginCallResult3 reqMarginCallResult )
    {
        MarginCallResult = reqMarginCallResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_xnJ10SqQEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcctId")]
    #endif
    [IsoXmlTag("CollAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    #else
    public CollateralAccount3? CollateralAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    [IsoId("_zXqKIyqQEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_xnJ10yqQEeyR9JrVGfaMKw")]
    [DisplayName("Margin Call Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnCallRslt")]
    #endif
    [IsoXmlTag("MrgnCallRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginCallResult3 MarginCallResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginCallResult3 MarginCallResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCallResult3 MarginCallResult { get; init; } 
    #else
    public MarginCallResult3 MarginCallResult { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_xnJ11SqQEeyR9JrVGfaMKw")]
    [DisplayName("Margin Detail Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlDueToA")]
    #endif
    [IsoXmlTag("MrgnDtlDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailDueToA { get; init; } 
    #else
    public MarginCall1? MarginDetailDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_xnJ11yqQEeyR9JrVGfaMKw")]
    [DisplayName("Margin Detail Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlDueToB")]
    #endif
    [IsoXmlTag("MrgnDtlDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailDueToB { get; init; } 
    #else
    public MarginCall1? MarginDetailDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_xnJ12SqQEeyR9JrVGfaMKw")]
    [DisplayName("Requirement Details Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqrmntDtlsDueToA")]
    #endif
    [IsoXmlTag("RqrmntDtlsDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    #else
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_xnJ12yqQEeyR9JrVGfaMKw")]
    [DisplayName("Requirement Details Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RqrmntDtlsDueToB")]
    #endif
    [IsoXmlTag("RqrmntDtlsDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    #else
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_xnJ13SqQEeyR9JrVGfaMKw")]
    [DisplayName("Expected Collateral Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdCollDueToA")]
    #endif
    [IsoXmlTag("XpctdCollDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; } 
    #else
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_xnJ13yqQEeyR9JrVGfaMKw")]
    [DisplayName("Expected Collateral Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdCollDueToB")]
    #endif
    [IsoXmlTag("XpctdCollDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; } 
    #else
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; set; } 
    #endif
    
    
    #nullable disable
    
}

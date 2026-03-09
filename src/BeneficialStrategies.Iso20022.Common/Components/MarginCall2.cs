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
[IsoId("_gfK1AILVEeWrrO9HojbPQA")]
[DisplayName("Margin Call")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCall2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCall2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCall2( MarginCallResult3 reqMarginCallResult )
    {
        MarginCallResult = reqMarginCallResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    [IsoId("_ZJDtoILWEeWrrO9HojbPQA")]
    [DisplayName("Collateral Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollAcctId")]
    #endif
    [IsoXmlTag("CollAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAccount2? CollateralAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAccount2? CollateralAccountIdentification { get; init; } 
    #else
    public CollateralAccount2? CollateralAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_Hey14ILXEeWrrO9HojbPQA")]
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
    [IsoId("_rzRKAILWEeWrrO9HojbPQA")]
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
    [IsoId("_zRi5cILWEeWrrO9HojbPQA")]
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
    [IsoId("_3Lsa0ILWEeWrrO9HojbPQA")]
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
    [IsoId("_Apw3wILXEeWrrO9HojbPQA")]
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
    [IsoId("_bkuCUILXEeWrrO9HojbPQA")]
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
    [IsoId("_ioK28ILXEeWrrO9HojbPQA")]
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

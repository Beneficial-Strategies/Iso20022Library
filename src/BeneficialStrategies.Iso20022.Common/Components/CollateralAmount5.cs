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
/// Collateral and settlement related amounts.
/// </summary>
[IsoId("__fRWYOCuEei2UYJ62ws-Fw")]
[DisplayName("Collateral Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralAmount5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Margin amount needed when the instruction reported creates an exposure.
    /// </summary>
    [IsoId("_MMFAMOCvEei2UYJ62ws-Fw")]
    [DisplayName("Required Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdMrgn")]
    #endif
    [IsoXmlTag("ReqrdMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? RequiredMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? RequiredMargin { get; init; } 
    #else
    public AmountAndDirection44? RequiredMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Amount which is collateralised.
    /// Feedback 
    /// </summary>
    [IsoId("_Vu8dkOCvEei2UYJ62ws-Fw")]
    [DisplayName("Collateralised")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collsd")]
    #endif
    [IsoXmlTag("Collsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? Collateralised { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? Collateralised { get; init; } 
    #else
    public AmountAndDirection44? Collateralised { get; set; } 
    #endif
    
    /// <summary>
    /// Outstanding amount to be covered, collateralised.
    /// </summary>
    [IsoId("_eh0ocOCvEei2UYJ62ws-Fw")]
    [DisplayName("Remaining Collateralised")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngCollsd")]
    #endif
    [IsoXmlTag("RmngCollsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? RemainingCollateralised { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? RemainingCollateralised { get; init; } 
    #else
    public AmountAndDirection44? RemainingCollateralised { get; set; } 
    #endif
    
    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s position.
    /// </summary>
    [IsoId("_jsfWgOCvEei2UYJ62ws-Fw")]
    [DisplayName("Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttld")]
    #endif
    [IsoXmlTag("Sttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? Settled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? Settled { get; init; } 
    #else
    public AmountAndDirection44? Settled { get; set; } 
    #endif
    
    /// <summary>
    /// Amount due to be settled.    
    /// </summary>
    [IsoId("_sbiKQOCvEei2UYJ62ws-Fw")]
    [DisplayName("Remaining Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngSttlm")]
    #endif
    [IsoXmlTag("RmngSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection44? RemainingSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection44? RemainingSettlement { get; init; } 
    #else
    public AmountAndDirection44? RemainingSettlement { get; set; } 
    #endif
    
    
    #nullable disable
    
}

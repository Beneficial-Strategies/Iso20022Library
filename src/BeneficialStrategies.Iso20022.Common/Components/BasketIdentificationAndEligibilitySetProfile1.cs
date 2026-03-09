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
/// Provides information on the baskets identification and the Eligibility Set Profile.
/// </summary>
[IsoId("_rh-hcLzTEeivTd4NUfCi2g")]
[DisplayName("Basket Identification And Eligibility Set Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BasketIdentificationAndEligibilitySetProfile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the preferred collateral basket.
    /// </summary>
    [IsoId("_uukj0LzUEeivTd4NUfCi2g")]
    [DisplayName("Preferential Basket Identification Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfrntlBsktIdNb")]
    #endif
    [IsoXmlTag("PrfrntlBsktIdNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? PreferentialBasketIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? PreferentialBasketIdentificationNumber { get; init; } 
    #else
    public GenericIdentification1? PreferentialBasketIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the fallback starting collateral basket.
    /// </summary>
    [IsoId("_80k1MLzUEeivTd4NUfCi2g")]
    [DisplayName("Fallback Starting Basket Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FllbckStartgBsktId")]
    #endif
    [IsoXmlTag("FllbckStartgBsktId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? FallbackStartingBasketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? FallbackStartingBasketIdentification { get; init; } 
    #else
    public GenericIdentification1? FallbackStartingBasketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the collateral basket to be excluded.
    /// </summary>
    [IsoId("_Nc55YLzVEeivTd4NUfCi2g")]
    [DisplayName("Exclusion Basket Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExclsnBsktId")]
    #endif
    [IsoXmlTag("ExclsnBsktId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? ExclusionBasketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? ExclusionBasketIdentification { get; init; } 
    #else
    public GenericIdentification1? ExclusionBasketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_UNrpoLzVEeivTd4NUfCi2g")]
    [DisplayName("Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltySetPrfl")]
    #endif
    [IsoXmlTag("ElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #else
    public GenericIdentification1? EligibilitySetProfile { get; set; } 
    #endif
    
    
    #nullable disable
    
}

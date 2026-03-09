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
/// Amount of collateral calculated pre-haircut and/or post-haircut.
/// </summary>
[IsoId("_SUuMwFfVEeqqKf65rDYWYw")]
[DisplayName("Pre Post Haircut")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PrePostHaircut1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the amount of collateral calculated pre-haircut.
    /// </summary>
    [IsoId("_ikXEIFfVEeqqKf65rDYWYw")]
    [DisplayName("Pre Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreHrcut")]
    #endif
    [IsoXmlTag("PreHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PreHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PreHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PreHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the amount of collateral calculated post-haircut.
    /// </summary>
    [IsoId("_j8ulQFfVEeqqKf65rDYWYw")]
    [DisplayName("Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstHrcut")]
    #endif
    [IsoXmlTag("PstHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PostHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PostHaircut { get; set; } 
    #endif
    
    
    #nullable disable
    
}

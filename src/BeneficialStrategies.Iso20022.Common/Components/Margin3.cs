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
/// Provides details on the calculation of the margin.
/// </summary>
[IsoId("_-eMvBKMOEeCojJW5vEuTEQ_631064077")]
[DisplayName("Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Margin3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// </summary>
    [IsoId("_-eMvBaMOEeCojJW5vEuTEQ_937741961")]
    [DisplayName("Initial Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgn")]
    #endif
    [IsoXmlTag("InitlMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2? InitialMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2? InitialMargin { get; init; } 
    #else
    public Amount2? InitialMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the calculation of the variation margin.
    /// </summary>
    [IsoId("_-eMvBqMOEeCojJW5vEuTEQ_2054797146")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VariationMargin3? VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VariationMargin3? VariationMargin { get; init; } 
    #else
    public VariationMargin3? VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the margin type and amount.
    /// </summary>
    [IsoId("_-eMvB6MOEeCojJW5vEuTEQ_-399143130")]
    [DisplayName("Other Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrMrgn")]
    #endif
    [IsoXmlTag("OthrMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Margin4? OtherMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Margin4? OtherMargin { get; init; } 
    #else
    public Margin4? OtherMargin { get; set; } 
    #endif
    
    
    #nullable disable
    
}

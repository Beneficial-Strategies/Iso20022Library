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
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_hX_uQSqeEeObprHJy8Zrxg")]
[DisplayName("Corporate Action Preliminary Advice Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPreliminaryAdviceType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionPreliminaryAdviceType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionPreliminaryAdviceType2( CorporateActionPreliminaryAdviceType1Code reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of movement preliminary advice, for example. new or replacement.
    /// </summary>
    [IsoId("_hvNUYSqeEeObprHJy8Zrxg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #else
    public CorporateActionPreliminaryAdviceType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the movement preliminary advice is sent after entitlement date.
    /// Value is Yes (true) if sent after entitlement date and No (false) if sent before entitlement date.
    /// </summary>
    [IsoId("_hvNUcSqeEeObprHJy8Zrxg")]
    [DisplayName("Eligibility Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltyInd")]
    #endif
    [IsoXmlTag("ElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibilityIndicator { get; init; } 
    #else
    public System.String? EligibilityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}

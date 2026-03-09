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
/// Derivative instrument that gives the buyer the right but not the obligation to purchase a set of quantity of a financial instrument at a future date.
/// </summary>
[IsoId("_d3DnkchsEeadgvwNGwK05w")]
[DisplayName("Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Option14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Expiration style of the option.
    /// </summary>
    [IsoId("_d_smOchsEeadgvwNGwK05w")]
    [DisplayName("Expiration Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnStyle")]
    #endif
    [IsoXmlTag("XprtnStyle")]
    [MinLength(1)]
    [MaxLength(4)]
    public SimpleValueList<OptionStyle5Code> ExpirationStyle { get; init; } = new SimpleValueList<OptionStyle5Code>(){};
    
    /// <summary>
    /// Specifies how the option can be exercised.
    /// </summary>
    [IsoId("_d_smN8hsEeadgvwNGwK05w")]
    [DisplayName("Option Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStyle")]
    #endif
    [IsoXmlTag("OptnStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExoticOptionStyle1Code? OptionStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExoticOptionStyle1Code? OptionStyle { get; init; } 
    #else
    public ExoticOptionStyle1Code? OptionStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the option is a call or a put.
    /// </summary>
    [IsoId("_d_smO8hsEeadgvwNGwK05w")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType1Code? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType1Code? OptionType { get; init; } 
    #else
    public OptionType1Code? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the option has a barrier.
    /// </summary>
    [IsoId("_d_smPchsEeadgvwNGwK05w")]
    [DisplayName("Barrier Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrrInd")]
    #endif
    [IsoXmlTag("BrrrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BarrierIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BarrierIndicator { get; init; } 
    #else
    public System.String? BarrierIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the event in the life of the option.
    /// </summary>
    [IsoId("_d_smQchsEeadgvwNGwK05w")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionEvent2? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionEvent2? EventType { get; init; } 
    #else
    public OptionEvent2? EventType { get; set; } 
    #endif
    
    
    #nullable disable
    
}

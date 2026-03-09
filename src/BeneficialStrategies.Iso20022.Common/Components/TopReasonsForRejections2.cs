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
/// Identification of the most common data field that has not passed the validation rule.
/// </summary>
[IsoId("_NeaEeVfdEeqZr5K1Woax-g")]
[DisplayName("Top Reasons For Rejections")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TopReasonsForRejections2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for all derivatives.
    /// </summary>
    [IsoId("_N1g84VfdEeqZr5K1Woax-g")]
    [DisplayName("All")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="All")]
    #endif
    [IsoXmlTag("All")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? All { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? All { get; init; } 
    #else
    public System.String? All { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for derivatives which have been reported as new.
    /// </summary>
    [IsoId("_N1g841fdEeqZr5K1Woax-g")]
    [DisplayName("New")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="New")]
    #endif
    [IsoXmlTag("New")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? New { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? New { get; init; } 
    #else
    public System.String? New { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the most common data field that has not passed the validation rule for derivatives which have been reported as modification.
    /// </summary>
    [IsoId("_N1g85VfdEeqZr5K1Woax-g")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Modification { get; init; } 
    #else
    public System.String? Modification { get; set; } 
    #endif
    
    
    #nullable disable
    
}

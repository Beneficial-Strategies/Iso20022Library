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
/// Regulatory information.
/// </summary>
[IsoId("_uvgygxQLEeKCyZtSz_i3FA")]
[DisplayName("Regulatory Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sector of economic activity, for example, SAE in the Italian market.
    /// </summary>
    [IsoId("_CdjqcBQMEeKCyZtSz_i3FA")]
    [DisplayName("Sector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sctr")]
    #endif
    [IsoXmlTag("Sctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Sector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sector { get; init; } 
    #else
    public System.String? Sector { get; set; } 
    #endif
    
    /// <summary>
    /// Branch of economic activity, for example, RAE in the Italian market.
    /// </summary>
    [IsoId("_FLAvNRQMEeKCyZtSz_i3FA")]
    [DisplayName("Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnch")]
    #endif
    [IsoXmlTag("Brnch")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Branch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Branch { get; init; } 
    #else
    public System.String? Branch { get; set; } 
    #endif
    
    /// <summary>
    /// Group of economic activity, for example, a code issued by a regulator.
    /// </summary>
    [IsoId("_GK8iNxQMEeKCyZtSz_i3FA")]
    [DisplayName("Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp")]
    #endif
    [IsoXmlTag("Grp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Group { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Group { get; init; } 
    #else
    public System.String? Group { get; set; } 
    #endif
    
    /// <summary>
    /// Other regulatory information.
    /// </summary>
    [IsoId("_HCE-iRQMEeKCyZtSz_i3FA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Other { get; init; } 
    #else
    public System.String? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}

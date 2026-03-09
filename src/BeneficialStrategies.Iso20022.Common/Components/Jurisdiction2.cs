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
/// Contains information that identifies or is specific to a transaction jurisdiction.
/// </summary>
[IsoId("_uh9kAMVaEeuips4fuphvoQ")]
[DisplayName("Jurisdiction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Jurisdiction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// When true, indicates the transaction is considered to be domestic.
    /// </summary>
    [IsoId("_YK-ecMVbEeuips4fuphvoQ")]
    [DisplayName("Domestic Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmstInd")]
    #endif
    [IsoXmlTag("DmstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DomesticIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DomesticIndicator { get; init; } 
    #else
    public System.String? DomesticIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the reason the transaction is considered to be domestic or non-domestic.
    /// </summary>
    [IsoId("_eot98MVbEeuips4fuphvoQ")]
    [DisplayName("Domestic Qualification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmstQlfctn")]
    #endif
    [IsoXmlTag("DmstQlfctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DomesticQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DomesticQualification { get; init; } 
    #else
    public System.String? DomesticQualification { get; set; } 
    #endif
    
    
    #nullable disable
    
}

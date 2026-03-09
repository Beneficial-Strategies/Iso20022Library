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
/// Information for the presentation of documents.
/// </summary>
[IsoId("_vsXgeX1qEeGlwNeVP9egyg")]
[DisplayName("Presentation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Presentation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Medium through which the presentation can be submitted such as paper, electronic or both.
    /// </summary>
    [IsoId("_vsXgfH1qEeGlwNeVP9egyg")]
    [DisplayName("Medium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdm")]
    #endif
    [IsoXmlTag("Mdm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PresentationMedium1Choice_? Medium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentationMedium1Choice_? Medium { get; init; } 
    #else
    public PresentationMedium1Choice_? Medium { get; set; } 
    #endif
    
    /// <summary>
    /// Document required to be presented.
    /// </summary>
    [IsoId("_vsXgh31qEeGlwNeVP9egyg")]
    [DisplayName("Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Doc")]
    #endif
    [IsoXmlTag("Doc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document11? Document { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document11? Document { get; init; } 
    #else
    public Document11? Document { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the presentation.
    /// </summary>
    [IsoId("_vsXgf31qEeGlwNeVP9egyg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}

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
/// Information about a document.
/// </summary>
[IsoId("_XdB_6H1wEeGlwNeVP9egyg")]
[DisplayName("Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Document11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_XdB_7n1wEeGlwNeVP9egyg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PresentationDocumentFormat1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentationDocumentFormat1Choice_? Type { get; init; } 
    #else
    public PresentationDocumentFormat1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Wording for document.
    /// </summary>
    [IsoId("_XdB_8X1wEeGlwNeVP9egyg")]
    [DisplayName("Wording")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wrdg")]
    #endif
    [IsoXmlTag("Wrdg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? Wording { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Wording { get; init; } 
    #else
    public System.String? Wording { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to an electronic presentation.
    /// </summary>
    [IsoId("_XdB_631wEeGlwNeVP9egyg")]
    [DisplayName("Electronic Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncDtls")]
    #endif
    [IsoXmlTag("ElctrncDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Presentation3? ElectronicDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Presentation3? ElectronicDetails { get; init; } 
    #else
    public Presentation3? ElectronicDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}

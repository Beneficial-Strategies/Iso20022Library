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
/// Assessments for the component of the point of interaction.
/// </summary>
[IsoId("_0nUakAyQEeKa_56Jbsi1RQ")]
[DisplayName("Point Of Interaction Component Assessment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponentAssessment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponentAssessment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponentAssessment1( POIComponentAssessment1Code reqType,System.String reqNumber )
    {
        Type = reqType;
        Number = reqNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of assessment of the component.
    /// </summary>
    [IsoId("_Buco4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentAssessment1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentAssessment1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentAssessment1Code Type { get; init; } 
    #else
    public POIComponentAssessment1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Body which has delivered the assessment.
    /// </summary>
    [IsoId("_L3GT4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> Assigner { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _L3GT4AyREeKa_56Jbsi1RQ
    
    /// <summary>
    /// Date when the assessment has been delivered.
    /// </summary>
    [IsoId("_TwUS4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDt")]
    #endif
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DeliveryDate { get; init; } 
    #else
    public System.DateTime? DeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the assessment will expire.
    /// </summary>
    [IsoId("_cJlD4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpirationDate { get; init; } 
    #else
    public System.DateTime? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique assessment number for the component.
    /// </summary>
    [IsoId("_jKL_4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Number { get; init; } 
    #else
    public System.String Number { get; set; } 
    #endif
    
    
    #nullable disable
    
}

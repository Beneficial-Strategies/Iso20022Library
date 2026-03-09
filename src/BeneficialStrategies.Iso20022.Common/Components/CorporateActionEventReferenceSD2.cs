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
/// Provides additional information regarding linkage details.
/// </summary>
[IsoId("_1UHa8jL3EeKU9IrkkToqcw_-607146504")]
[DisplayName("Corporate Action Event Reference SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventReferenceSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionEventReferenceSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionEventReferenceSD2( System.String reqPlaceAndName,DTCCLinkType1Code reqLinkageType,System.DateOnly reqLinkAddedDate )
    {
        PlaceAndName = reqPlaceAndName;
        LinkageType = reqLinkageType;
        LinkAddedDate = reqLinkAddedDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1UHa8zL3EeKU9IrkkToqcw_-419438120")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    [IsoId("_1UHa9DL3EeKU9IrkkToqcw_1303167805")]
    [DisplayName("Linkage Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkgTp")]
    #endif
    [IsoXmlTag("LkgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCLinkType1Code LinkageType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCLinkType1Code LinkageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCLinkType1Code LinkageType { get; init; } 
    #else
    public DTCCLinkType1Code LinkageType { get; set; } 
    #endif
    
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was established.
    /// </summary>
    [IsoId("_1UHa9TL3EeKU9IrkkToqcw_-1708581925")]
    [DisplayName("Link Added Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkAddedDt")]
    #endif
    [IsoXmlTag("LkAddedDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate LinkAddedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly LinkAddedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly LinkAddedDate { get; init; } 
    #else
    public System.DateOnly LinkAddedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was modified.
    /// </summary>
    [IsoId("_1UHa9jL3EeKU9IrkkToqcw_1601038639")]
    [DisplayName("Link Modified Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkModfdDt")]
    #endif
    [IsoXmlTag("LkModfdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LinkModifiedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LinkModifiedDate { get; init; } 
    #else
    public System.DateOnly? LinkModifiedDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

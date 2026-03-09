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
[IsoId("_pm0bkb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Cancellation SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionCancellationSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionCancellationSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionCancellationSD3( System.String reqLinkedCorporateActionIdentification,DTCCLinkType1Code reqLinkageType,System.DateOnly reqLinkAddedDate )
    {
        LinkedCorporateActionIdentification = reqLinkedCorporateActionIdentification;
        LinkageType = reqLinkageType;
        LinkAddedDate = reqLinkAddedDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_p4rAkL5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a related corporate action event.
    /// </summary>
    [IsoId("_p4rAkr5XEeexmbB7KsjCwA")]
    [DisplayName("Linked Corporate Action Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdCorpActnId")]
    #endif
    [IsoXmlTag("LkdCorpActnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text LinkedCorporateActionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LinkedCorporateActionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LinkedCorporateActionIdentification { get; init; } 
    #else
    public System.String LinkedCorporateActionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    [IsoId("_p4rAoL5XEeexmbB7KsjCwA")]
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
    [IsoId("_p4rAqL5XEeexmbB7KsjCwA")]
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
    [IsoId("_p4rAsL5XEeexmbB7KsjCwA")]
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

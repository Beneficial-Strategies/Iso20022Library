// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding linkage details.
/// </summary>
[IsoId("_1UHa8jL3EeKU9IrkkToqcw_-607146504")]
[DisplayName("Corporate Action Event Reference SD")]
public partial record CorporateActionEventReferenceSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1UHa8zL3EeKU9IrkkToqcw_-419438120")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates the reason why two or more events are related.
    /// </summary>
    [IsoId("_1UHa9DL3EeKU9IrkkToqcw_1303167805")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public required DTCCLinkType1Code LinkageType { get; init; } 
    
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was established.
    /// </summary>
    [IsoId("_1UHa9TL3EeKU9IrkkToqcw_-1708581925")]
    [DisplayName("Link Added Date")]
    [IsoXmlTag("LkAddedDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate LinkAddedDate { get; init; } 
    
    /// <summary>
    /// Events can be linked together. This date represents the date on which the link was modified.
    /// </summary>
    [IsoId("_1UHa9jL3EeKU9IrkkToqcw_1601038639")]
    [DisplayName("Link Modified Date")]
    [IsoXmlTag("LkModfdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LinkModifiedDate { get; init; } 
    
    
    #nullable disable
    
}

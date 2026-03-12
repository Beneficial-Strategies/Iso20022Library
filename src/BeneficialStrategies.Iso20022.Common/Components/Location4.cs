// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location information.
/// </summary>
[IsoId("_MbodocW3EeuhguwJmlgagQ")]
[DisplayName("Location")]
public partial record Location4
{
    #nullable enable
    
    /// <summary>
    /// Contains the location code.
    /// </summary>
    [IsoId("_Mf-yIcW3EeuhguwJmlgagQ")]
    [DisplayName("Location Code")]
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LocationCode { get; init; } 
    
    /// <summary>
    /// Name (label) of the location.
    /// </summary>
    [IsoId("_Mf-yI8W3EeuhguwJmlgagQ")]
    [DisplayName("Location Name")]
    [IsoXmlTag("LctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LocationName { get; init; } 
    
    /// <summary>
    /// Specific explanation of the location or directions. 
    /// </summary>
    [IsoId("_Mf-yJcW3EeuhguwJmlgagQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Description { get; init; } 
    
    /// <summary>
    /// Contains the address details. 
    /// </summary>
    [IsoId("_Mf-yJ8W3EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Local time zone.
    /// </summary>
    [IsoId("_Mf-yKcW3EeuhguwJmlgagQ")]
    [DisplayName("Local Time Zone")]
    [IsoXmlTag("LclTmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? LocalTimeZone { get; init; } 
    
    /// <summary>
    /// Local currency.
    /// </summary>
    [IsoId("_Mf-yK8W3EeuhguwJmlgagQ")]
    [DisplayName("Local Currency")]
    [IsoXmlTag("LclCcy")]
    public ISO3NumericCurrencyCode? LocalCurrency { get; init; } 
    
    
    #nullable disable
    
}

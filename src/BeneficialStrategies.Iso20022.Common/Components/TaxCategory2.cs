// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides identification information about the tax category. 
/// </summary>
[IsoId("_1VoBMOciEei5aPS232E3Mw")]
[DisplayName("Tax Category")]
public partial record TaxCategory2
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_LVO8wPGPEeiDXvNgp1r0vA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Tax category identification.
    /// </summary>
    [IsoId("_ebM3YecjEei5aPS232E3Mw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? Identification { get; init; } 
    
    /// <summary>
    /// Quantity to be withheld at the tax category level.
    /// </summary>
    [IsoId("_4crxYOclEei5aPS232E3Mw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public FinancialInstrumentQuantity15Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Identification of the country in which the tax is withheld.
    /// </summary>
    [IsoId("_Qj3K4OglEei5aPS232E3Mw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}

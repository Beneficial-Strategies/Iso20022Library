// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to choose between an amount or an unspecified rate.
/// </summary>
[IsoId("_1eZc4zLhEeGkgP4mOiMAHQ")]
[DisplayName("Gross Dividend Rate Format 6 SD")]
public partial record GrossDividendRateFormat6SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_4t4csFPHEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Provides the maximum dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_GNiV1TYmEeGFarbLo5oXPg")]
    [DisplayName("Maximum Dividend Rate")]
    [IsoXmlTag("MaxDvddRate")]
    public RateAndAmountFormat16Choice_? MaximumDividendRate { get; init; } 
    
    /// <summary>
    /// Provides the minimum dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_cumH9zYmEeGFarbLo5oXPg")]
    [DisplayName("Minimum Dividend Rate")]
    [IsoXmlTag("MinDvddRate")]
    public RateAndAmountFormat16Choice_? MinimumDividendRate { get; init; } 
    
    
    #nullable disable
    
}

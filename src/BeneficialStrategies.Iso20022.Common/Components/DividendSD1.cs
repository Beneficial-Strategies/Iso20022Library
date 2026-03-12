// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify rates of a corporate action.
/// </summary>
[IsoId("_LsY4IzLZEeGkgP4mOiMAHQ")]
[DisplayName("Dividend SD")]
public partial record DividendSD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_xoExQFO_EeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Provides the total annual dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_bSUrMDLZEeGkgP4mOiMAHQ")]
    [DisplayName("Total Annual Dividend Rate")]
    [IsoXmlTag("TtlAnlDvddRate")]
    public RateAndAmountFormat16Choice_? TotalAnnualDividendRate { get; init; } 
    
    /// <summary>
    /// Provides the maximum annual total dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_pHPk4DLfEeGkgP4mOiMAHQ")]
    [DisplayName("Maximum Annual Total Dividend Rate")]
    [IsoXmlTag("MaxAnlTtlDvddRate")]
    public RateAndAmountFormat16Choice_? MaximumAnnualTotalDividendRate { get; init; } 
    
    /// <summary>
    /// Provides the minimum annual total dividend rate as announced by the Issuer.
    /// </summary>
    [IsoId("_sTihwDLfEeGkgP4mOiMAHQ")]
    [DisplayName("Minimum Annual Total Dividend Rate")]
    [IsoXmlTag("MinAnlTtlDvddRate")]
    public RateAndAmountFormat16Choice_? MinimumAnnualTotalDividendRate { get; init; } 
    
    
    #nullable disable
    
}

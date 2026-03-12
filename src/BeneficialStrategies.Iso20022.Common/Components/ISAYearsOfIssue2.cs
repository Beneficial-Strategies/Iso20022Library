// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_SvuTrNp-Ed-ak6NoX_4Aeg_-594935338")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue2
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTrdp-Ed-ak6NoX_4Aeg_-594935302")]
    [DisplayName("Current Year Type")]
    [IsoXmlTag("CurYrTp")]
    public ISAType2Code? CurrentYearType { get; init; } 
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_Sv3dkNp-Ed-ak6NoX_4Aeg_-594934953")]
    [DisplayName("Extended Current Year Type")]
    [IsoXmlTag("XtndedCurYrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCurrentYearType { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Sv3dkdp-Ed-ak6NoX_4Aeg_524128518")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYearChoice_? PreviousYears { get; init; } 
    
    
    #nullable disable
    
}

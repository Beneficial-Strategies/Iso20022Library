// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action balance details.
/// </summary>
[IsoId("__1Zacb-zEeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Balance SD")]
public partial record CorporateActionBalanceSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_AEke4b-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Balance of uncovered protect transactions at an event level.
    /// </summary>
    [IsoId("_AEke47-0Eeeb2ZBoAlSG1Q")]
    [DisplayName("Total Uncovered Protect Balance")]
    [IsoXmlTag("TtlUcvrdPrtctBal")]
    public SignedQuantityFormat9? TotalUncoveredProtectBalance { get; init; } 
    
    
    #nullable disable
    
}

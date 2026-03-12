// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
/// </summary>
[IsoId("_gJxZ2zi8Eeydid5dcNPKvg")]
[DisplayName("Opening Balance")]
public partial record OpeningBalance6
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_gJxZ3zi8Eeydid5dcNPKvg")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_gJxZ5zi8Eeydid5dcNPKvg")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public required OpeningBalance7Choice_ OpeningBalance { get; init; } 
    
    
    #nullable disable
    
}

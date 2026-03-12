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
[IsoId("_8bhdVZNLEeWGlc8L7oPDIg")]
[DisplayName("Opening Balance")]
public partial record OpeningBalance4
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_8bhdWZNLEeWGlc8L7oPDIg")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_8bhdYZNLEeWGlc8L7oPDIg")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public required OpeningBalance5Choice_ OpeningBalance { get; init; } 
    
    
    #nullable disable
    
}

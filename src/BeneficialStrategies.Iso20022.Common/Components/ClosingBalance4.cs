// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
/// </summary>
[IsoId("_8bhd5ZNLEeWGlc8L7oPDIg")]
[DisplayName("Closing Balance")]
public partial record ClosingBalance4
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_8bhd6ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_8bhd8ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public required ClosingBalance5Choice_ ClosingBalance { get; init; } 
    
    
    #nullable disable
    
}

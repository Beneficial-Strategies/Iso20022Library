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
[IsoId("__ZNdESp7EeyR9JrVGfaMKw")]
[DisplayName("Opening Balance")]
public partial record OpeningBalance5
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("__xDVQyp7EeyR9JrVGfaMKw")]
    [DisplayName("Short Long Indicator")]
    [IsoXmlTag("ShrtLngInd")]
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("__xDVSyp7EeyR9JrVGfaMKw")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public required OpeningBalance6Choice_ OpeningBalance { get; init; } 
    
    
    #nullable disable
    
}

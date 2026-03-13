// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform in case of error on the related action in progress.
/// </summary>
[IsoId("_ZzbQcbC6EeamYaqfhG1ZuA")]
[DisplayName("Error Action")]
public partial record ErrorAction3
{
    #nullable enable
    
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    [IsoId("_Z-TDsbC6EeamYaqfhG1ZuA")]
    [DisplayName("Action Result")]
    [IsoXmlTag("ActnRslt")]
    public SimpleValueList<TerminalManagementActionResult3Code> ActionResult { get; init; } = [];
    // ID for the above is _Z-TDsbC6EeamYaqfhG1ZuA
    
    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    [IsoId("_Z-TDs7C6EeamYaqfhG1ZuA")]
    [DisplayName("Action To Process")]
    [IsoXmlTag("ActnToPrc")]
    public required TerminalManagementErrorAction2Code ActionToProcess { get; init; } 
    
    
    #nullable disable
    
}

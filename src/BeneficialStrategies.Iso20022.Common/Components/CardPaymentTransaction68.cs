// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
[IsoId("_75__YazkEeaS8qpTeYtFzA")]
[DisplayName("Card Payment Transaction")]
public partial record CardPaymentTransaction68
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_8FTQcazkEeaS8qpTeYtFzA")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult12 AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_8FTQc6zkEeaS8qpTeYtFzA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action8? Action { get; init; } 
    
    
    #nullable disable
    
}

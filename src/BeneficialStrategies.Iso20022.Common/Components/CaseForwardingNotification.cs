// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a case resulting from a case assignment.
/// </summary>
[IsoId("_VJDihdp-Ed-ak6NoX_4Aeg_92437135")]
[DisplayName("Case Forwarding Notification")]
public record CaseForwardingNotification
{
    /// <summary>
    /// Justification for the forward action.
    /// </summary>
    [IsoId("_VJDihtp-Ed-ak6NoX_4Aeg_172785479")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required CaseForwardingNotification1Code Justification { get; init; }
}

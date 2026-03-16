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
[IsoId("_T-ZtQtp-Ed-ak6NoX_4Aeg_-1114775558")]
[DisplayName("Case Forwarding Notification")]
public record CaseForwardingNotification3
{
    /// <summary>
    /// Justification for the forward action.
    /// </summary>
    [IsoId("_T-ZtQ9p-Ed-ak6NoX_4Aeg_-1114775467")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public required CaseForwardingNotification3Code Justification { get; init; }
}

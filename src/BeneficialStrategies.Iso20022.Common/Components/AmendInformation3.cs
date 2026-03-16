// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specific to an amendment.
/// </summary>
[IsoId("_pCYD0XFzEeSuDsBOD9TlUw")]
[DisplayName("Amend Information")]
public record AmendInformation3
{
    /// <summary>
    /// Identifies the MeetingResultDissemination message to be amended.
    /// </summary>
    [IsoId("_pfO-83FzEeSuDsBOD9TlUw")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required MessageIdentification PreviousReference { get; init; }
}

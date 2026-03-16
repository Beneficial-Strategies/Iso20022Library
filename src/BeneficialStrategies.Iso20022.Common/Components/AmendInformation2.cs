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
[IsoId("_RVa40Np-Ed-ak6NoX_4Aeg_-5632894")]
[DisplayName("Amend Information")]
public record AmendInformation2
{
    /// <summary>
    /// Identifies the MeetingResultDissemination essage to be amended.
    /// </summary>
    [IsoId("_RVa40dp-Ed-ak6NoX_4Aeg_1569327145")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required MessageIdentification PreviousReference { get; init; }
}

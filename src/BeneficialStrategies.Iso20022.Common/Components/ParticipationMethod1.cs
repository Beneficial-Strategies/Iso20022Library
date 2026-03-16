// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method of voting participation to a general meeting.
/// </summary>
[IsoId("_N5h4UK32EemG7MmivSuE5g")]
[DisplayName("Participation Method")]
public record ParticipationMethod1
{
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_13F9kK32EemG7MmivSuE5g")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public required ParticipationMethod1Choice_ ParticipationMethod { get; init; }

    /// <summary>
    /// Deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_J_eoIK33EemG7MmivSuE5g")]
    [DisplayName("Issuer Deadline For Voting")]
    [IsoXmlTag("IssrDdlnForVtng")]
    public required DateFormat58Choice_ IssuerDeadlineForVoting { get; init; }
}

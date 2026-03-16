// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the agent.
/// </summary>
[IsoId("_Pc3bwNp-Ed-ak6NoX_4Aeg_-1605492911")]
[DisplayName("Corporate Action Agent")]
public record CorporateActionAgent1
{
    /// <summary>
    /// Identification of the agent.
    /// </summary>
    [IsoId("_Pc3bwdp-Ed-ak6NoX_4Aeg_637142441")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    public required PartyIdentification2Choice_ AgentIdentification { get; init; }

    /// <summary>
    /// Role played by the agent.
    /// </summary>
    [IsoId("_Pc3bwtp-Ed-ak6NoX_4Aeg_762741819")]
    [DisplayName("Agent Role")]
    [IsoXmlTag("AgtRole")]
    public required AgentRole1FormatChoice_ AgentRole { get; init; }

    /// <summary>
    /// Contact person at the agent.
    /// </summary>
    [IsoId("_Pc3bw9p-Ed-ak6NoX_4Aeg_518579733")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public NameAndAddress5? ContactPerson { get; init; }
}

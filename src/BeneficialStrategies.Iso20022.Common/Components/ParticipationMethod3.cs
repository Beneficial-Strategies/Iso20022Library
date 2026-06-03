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
[IsoId("_hCt54ajJEfCzuLlmLrhIvA")]
[DisplayName("Participation Method3")]
public record ParticipationMethod3
{
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_hKYBEajJEfCzuLlmLrhIvA")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public required ParticipationMethod3Choice ParticipationMethod { get; init; }

    /// <summary>
    /// Indicates whether the email address of the party who will attend the virtual meeting must be provided in the Meeting Instruction.
    /// </summary>
    [IsoId("_y0Zy0KjJEfCzuLlmLrhIvA")]
    [DisplayName("Attendee Email Required Indicator")]
    [IsoXmlTag("AttndeeEmailReqrdInd")]
    public IsoYesNoIndicator? AttendeeEmailRequiredIndicator { get; init; }

    /// <summary>
    /// Deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_hKYBE6jJEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Deadline For Voting")]
    [IsoXmlTag("IssrDdlnForVtng")]
    public required DateFormat58Choice IssuerDeadlineForVoting { get; init; }

    /// <summary>
    /// Indicates whether the specific participation method proposed by the issuer is supported by the account servicer.
    /// </summary>
    [IsoId("_hKYBFajJEfCzuLlmLrhIvA")]
    [DisplayName("Supported By Account Servicer")]
    [IsoXmlTag("SpprtdByAcctSvcr")]
    public IsoYesNoIndicator? SupportedByAccountServicer { get; init; }

    /// <summary>
    /// Account servicer deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_hKYBF6jJEfCzuLlmLrhIvA")]
    [DisplayName("Response Deadline For Voting")]
    [IsoXmlTag("RspnDdlnForVtng")]
    public DateFormat58Choice? ResponseDeadlineForVoting { get; init; }

    /// <summary>
    /// Investor types that may or may not participate in the event.
    /// </summary>
    [IsoId("_mzh-sK5rEfCUHaCK5HWOhg")]
    [DisplayName("Investor Type Identification")]
    [IsoXmlTag("InvstrTpId")]
    public ValueList<InvestorTypeIdentification1> InvestorTypeIdentification { get; init; } = [];
}

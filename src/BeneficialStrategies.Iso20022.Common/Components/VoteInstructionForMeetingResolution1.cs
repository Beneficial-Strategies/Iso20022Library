// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote instruction applying to resolutions added during the meeting.
/// </summary>
[IsoId("_TLJEUNp-Ed-ak6NoX_4Aeg_1597899369")]
[DisplayName("Vote Instruction For Meeting Resolution")]
public record VoteInstructionForMeetingResolution1
{
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TLJEUdp-Ed-ak6NoX_4Aeg_1597899371")]
    [DisplayName("Vote Indication")]
    [IsoXmlTag("VoteIndctn")]
    public required VoteInstructionAtMeeting1Code VoteIndication { get; init; }

    /// <summary>
    /// Specifies the name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TLJEUtp-Ed-ak6NoX_4Aeg_1597899431")]
    [DisplayName("Shareholder")]
    [IsoXmlTag("Shrhldr")]
    public required NameAndAddress9 Shareholder { get; init; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution3Choice
{
    /// <summary>
    /// Name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
    /// </summary>
    [IsoId("_n0rhBa4dEemG7MmivSuE5g")]
    [DisplayName("Shareholder")]
    [IsoXmlTag("Shrhldr")]
    public record Shareholder : VoteInstructionForMeetingResolution3Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PbrI9tp-Ed-ak6NoX_4Aeg_290283597")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_PbrI99p-Ed-ak6NoX_4Aeg_291203604")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public LongPostalAddress2Choice_? Address { get; init; }
    }
}

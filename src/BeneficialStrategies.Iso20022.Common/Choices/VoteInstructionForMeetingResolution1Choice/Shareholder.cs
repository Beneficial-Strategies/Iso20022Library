// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteInstructionForMeetingResolution1Choice
{
    /// <summary>
    /// Specifies the name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TK1iUtp-Ed-ak6NoX_4Aeg_853994754")]
    [DisplayName("Shareholder")]
    public record Shareholder : VoteInstructionForMeetingResolution1Choice_
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

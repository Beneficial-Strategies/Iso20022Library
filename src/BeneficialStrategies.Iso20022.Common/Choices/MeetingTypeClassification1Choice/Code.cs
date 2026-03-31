// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MeetingTypeClassification1Choice
{
    /// <summary>
    /// Classifies the type of meeting.
    /// </summary>
    [IsoId("_RDrokdp-Ed-ak6NoX_4Aeg_865867729")]
    [DisplayName("Code")]
    public record Code : MeetingTypeClassification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Classifies the meeting type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MeetingTypeClassification1Code Value { get; init; }
    }
}

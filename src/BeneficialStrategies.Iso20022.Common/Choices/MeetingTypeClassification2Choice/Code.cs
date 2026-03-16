// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MeetingTypeClassification2Choice
{
    /// <summary>
    /// Type of meeting expressed as a code.
    /// </summary>
    [IsoId("_e0JEoa7NEemG7MmivSuE5g")]
    [DisplayName("Code")]
    public record Code : MeetingTypeClassification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Classifies the meeting type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MeetingTypeClassification2Code Value { get; init; }
    }
}

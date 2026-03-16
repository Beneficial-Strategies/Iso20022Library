// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TrackerParty3Choice
{
    /// <summary>
    /// Private Identification.
    /// </summary>
    [DisplayName("Private Identification")]
    public record PrivateIdentification : TrackerParty3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrvtId")]
        public required PersonIdentification18 Value { get; init; }
    }
}

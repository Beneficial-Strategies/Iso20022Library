// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrGroup3Choice
{
    /// <summary>
    /// Group Identification.
    /// </summary>
    [DisplayName("Group Identification")]
    public record GroupIdentification : PartyOrGroup3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("GrpId")]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}

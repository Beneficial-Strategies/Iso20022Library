// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrGroup2Choice
{
    /// <summary>
    /// Specifies the identification of a group of parties.
    /// </summary>
    [IsoId("_DDQTgW49EeiU9cctagi5ow")]
    [DisplayName("Group Identification")]
    public record GroupIdentification : PartyOrGroup2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("GrpId")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}

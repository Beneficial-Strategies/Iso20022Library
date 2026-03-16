// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References54Choice
{
    /// <summary>
    /// Unambiguous identification of the intra-position movement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_6GW88ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Intra Position Movement Identification")]
    public record IntraPositionMovementIdentification : References54Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text Value { get; init; }
    }
}

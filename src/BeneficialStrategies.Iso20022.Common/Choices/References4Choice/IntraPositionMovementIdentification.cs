// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References4Choice
{
    /// <summary>
    /// Reference to the intra-position movement transaction requested to be cancelled as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_UR6fL9p-Ed-ak6NoX_4Aeg_1430398311")]
    [DisplayName("Intra Position Movement Identification")]
    public record IntraPositionMovementIdentification : References4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References1Choice
{
    /// <summary>
    /// Unambiguous identification of the intra-position movement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_USg8GNp-Ed-ak6NoX_4Aeg_-1375232370")]
    [DisplayName("Intra Position Movement Identification")]
    public record IntraPositionMovementIdentification : References1Choice_
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

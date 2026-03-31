// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <summary>
    /// Intra Position Movement Identification.
    /// </summary>
    [DisplayName("Intra Position Movement Identification")]
    public record IntraPositionMovementIdentification : References80Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntId")]
        public required IsoMax35Text Value { get; init; }
    }
}

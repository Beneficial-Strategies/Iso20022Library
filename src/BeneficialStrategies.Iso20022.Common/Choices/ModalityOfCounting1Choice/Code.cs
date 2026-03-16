// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModalityOfCounting1Choice
{
    /// <summary>
    /// Modality of counting expressed as a code.
    /// </summary>
    [IsoId("_eYiLAK-vEemJ1NnLPsTFaw")]
    [DisplayName("Code")]
    public record Code : ModalityOfCounting1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the modality through which the votes that have been recorded and counted.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModalityOfCounting1Code Value { get; init; }
    }
}

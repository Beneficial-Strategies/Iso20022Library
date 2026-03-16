// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Liability1Choice
{
    /// <summary>
    /// Liability expressed as a code.
    /// </summary>
    [IsoId("_gHJNoCDMEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public record Code : Liability1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the party responsible for the liability.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Liability1Code Value { get; init; }
    }
}

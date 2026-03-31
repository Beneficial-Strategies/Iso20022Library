// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InformationTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the information type required.
    /// </summary>
    [IsoId("_ORF9wCXbEeOFIcNWlDEvdQ")]
    [DisplayName("Code")]
    public record Code : InformationTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of information event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionInformationType1Code Value { get; init; }
    }
}

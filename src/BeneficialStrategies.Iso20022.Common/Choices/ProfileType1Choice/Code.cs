// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProfileType1Choice
{
    /// <summary>
    /// Type of profile expressed as a code.
    /// </summary>
    [IsoId("_wl30cCDNEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public record Code : ProfileType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of profile.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProfileType1Code Value { get; init; }
    }
}

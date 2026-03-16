// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InitialPhysicalForm4Choice
{
    /// <summary>
    /// Initial physical form expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Usd_8eLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : InitialPhysicalForm4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the physical form of the securities.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InitialPhysicalForm1Code Value { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CivilStatus1Choice
{
    /// <summary>
    /// Civil status expressed as a code.
    /// </summary>
    [IsoId("_8saB4CCgEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public record Code : CivilStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the civil status of a person.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CivilStatus1Code Value { get; init; }
    }
}

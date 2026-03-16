// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CompanyLink1Choice
{
    /// <summary>
    /// Company link expressed as a code.
    /// </summary>
    [IsoId("_6ha1MCCZEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public record Code : CompanyLink1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of links to a company.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CompanyLink1Code Value { get; init; }
    }
}

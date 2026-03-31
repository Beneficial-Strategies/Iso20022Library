// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Removal1Choice
{
    /// <summary>
    /// Specifies the removal processing change requested expressed as a code.
    /// </summary>
    [IsoId("_xeEJoPkREeicy5Zn42b9bg")]
    [DisplayName("Code")]
    public record Code : Removal1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the removal process.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancialInstrumentRemoval1Code Value { get; init; }
    }
}

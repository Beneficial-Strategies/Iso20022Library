// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BeneficiaryType1Choice
{
    /// <summary>
    /// Type of beneficiary expressed as a code.
    /// </summary>
    [IsoId("_3a4XoFNgEeijdq8ilaxyOA")]
    [DisplayName("Code")]
    public record Code : BeneficiaryType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of beneficiary.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BeneficiaryType1Code Value { get; init; }
    }
}

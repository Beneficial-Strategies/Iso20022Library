// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice
{
    /// <summary>
    /// Details specific for a credit derivative.
    /// </summary>
    [IsoId("_xH-zaye0Eei12pGEsJIAeQ")]
    [DisplayName("Credit")]
    public partial record Credit : Derivative3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cdt")]
        public required CreditDefaultSwapsDerivative4Choice_ Value { get; init; }
    }
}

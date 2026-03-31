// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FormOfSecurity2Choice
{
    /// <summary>
    /// Form of the security expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QvHt19p-Ed-ak6NoX_4Aeg_2137358938")]
    [DisplayName("Code")]
    public record Code : FormOfSecurity2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Form of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FormOfSecurity1Code Value { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity5Choice
{
    /// <summary>
    /// Standard code to specify quantity of a financial instrument.
    /// </summary>
    [IsoId("_Sn0U1tp-Ed-ak6NoX_4Aeg_531493414")]
    [DisplayName("Code")]
    public record Code : Quantity5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies quantity of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Quantity1Code Value { get; init; }
    }
}

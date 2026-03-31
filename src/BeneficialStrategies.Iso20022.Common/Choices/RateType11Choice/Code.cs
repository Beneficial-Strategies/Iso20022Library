// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType11Choice
{
    /// <summary>
    /// Standard code to specify the type of tax rate.
    /// </summary>
    [IsoId("_Q2bPtdp-Ed-ak6NoX_4Aeg_-1984207669")]
    [DisplayName("Code")]
    public record Code : RateType11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of tax.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxType4Code Value { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateCode21Choice
{
    /// <summary>
    /// Standard code to specify the type of date.
    /// </summary>
    [IsoId("_b52h0UENEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : DateCode21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Type of date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DateType7Code Value { get; init; }
    }
}

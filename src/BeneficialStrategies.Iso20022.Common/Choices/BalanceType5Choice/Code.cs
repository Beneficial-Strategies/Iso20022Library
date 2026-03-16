// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType5Choice
{
    /// <summary>
    /// Balance type, in a coded form.
    /// </summary>
    [IsoId("_SYxMMdp-Ed-ak6NoX_4Aeg_1163104804")]
    [DisplayName("Code")]
    public record Code : BalanceType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the balance type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType12Code Value { get; init; }
    }
}

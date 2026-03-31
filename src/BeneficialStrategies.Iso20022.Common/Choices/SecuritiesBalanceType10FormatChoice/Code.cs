// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType10FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of securities balance.
    /// </summary>
    [IsoId("_RoygxNp-Ed-ak6NoX_4Aeg_-1171470357")]
    [DisplayName("Code")]
    public record Code : SecuritiesBalanceType10FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of securities balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType10Code Value { get; init; }
    }
}

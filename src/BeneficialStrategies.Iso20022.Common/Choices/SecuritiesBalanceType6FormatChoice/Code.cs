// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType6FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of securities balance.
    /// </summary>
    [IsoId("_Roygx9p-Ed-ak6NoX_4Aeg_-1140072113")]
    [DisplayName("Code")]
    public record Code : SecuritiesBalanceType6FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of securities balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType6Code Value { get; init; }
    }
}

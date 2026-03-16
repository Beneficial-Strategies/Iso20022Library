// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType2Choice
{
    /// <summary>
    /// Sub-balance expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtL0I9p-Ed-ak6NoX_4Aeg_-1926533181")]
    [DisplayName("Code")]
    public record Code : SecuritiesBalanceType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType13Code Value { get; init; }
    }
}

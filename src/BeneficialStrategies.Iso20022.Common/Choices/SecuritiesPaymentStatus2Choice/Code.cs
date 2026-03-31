// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesPaymentStatus2Choice
{
    /// <summary>
    /// Securities payment status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QvHt0dp-Ed-ak6NoX_4Aeg_805952471")]
    [DisplayName("Code")]
    public record Code : SecuritiesPaymentStatus2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the state of payment of a security at a particular time.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesPaymentStatus1Code Value { get; init; }
    }
}

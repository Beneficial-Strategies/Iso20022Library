// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentScheduleType2Choice
{
    /// <summary>
    /// Payment schedule type defined in a coded form.
    /// </summary>
    [IsoId("_TYa6Ubb1Eeu9Cp6InX88Vw")]
    [DisplayName("Code")]
    public record Code : PaymentScheduleType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a payment schedule type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PaymentScheduleType2Code Value { get; init; }
    }
}

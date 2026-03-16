// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther1Choice
{
    /// <summary>
    /// Specifies the payment period in coded form and a number of days.
    /// </summary>
    [IsoId("_uoAOcNP8EeK0PPbKncCqzA")]
    [DisplayName("Payment Code")]
    public record PaymentCode : PaymentCodeOrOther1Choice_
    {
        /// <summary>
        /// Code for the payment.
        /// </summary>
        [IsoId("_FlyjYdP-EeK0PPbKncCqzA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PaymentTime3Code Code { get; init; }

        /// <summary>
        /// Number of days after which the payment must be effected.
        /// </summary>
        [IsoId("_FlyjY9P-EeK0PPbKncCqzA")]
        [DisplayName("Number Of Days")]
        [IsoXmlTag("NbOfDays")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? NumberOfDays { get; init; }
    }
}

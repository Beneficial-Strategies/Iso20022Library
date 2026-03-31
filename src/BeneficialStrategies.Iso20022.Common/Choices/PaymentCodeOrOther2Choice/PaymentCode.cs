// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther2Choice
{
    /// <summary>
    /// Specifies the payment period in coded form and a number of days.
    /// </summary>
    [IsoId("_R2KHERVgEeOrY9qSHVspCA")]
    [DisplayName("Payment Code")]
    [IsoXmlTag("PmtCd")]
    public record PaymentCode : PaymentCodeOrOther2Choice_
    {
        /// <summary>
        /// Code for the payment.
        /// </summary>
        [IsoId("_IRIGgRVgEeOrY9qSHVspCA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PaymentTime4Code Code { get; init; }

        /// <summary>
        /// Number of days after which the payment must be effected.
        /// </summary>
        [IsoId("_IRIGgxVgEeOrY9qSHVspCA")]
        [DisplayName("Number Of Days")]
        [IsoXmlTag("NbOfDays")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? NumberOfDays { get; init; }
    }
}

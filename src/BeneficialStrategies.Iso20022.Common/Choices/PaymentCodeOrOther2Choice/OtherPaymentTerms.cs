// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther2Choice
{
    /// <summary>
    /// Specifies payment terms not present in a code list.
    /// </summary>
    [IsoId("_R2KHFRVgEeOrY9qSHVspCA")]
    [DisplayName("Other Payment Terms")]
    public record OtherPaymentTerms : PaymentCodeOrOther2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 140 characters.
        /// </summary>
        [IsoXmlTag("OthrPmtTerms")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text Value { get; init; }
    }
}

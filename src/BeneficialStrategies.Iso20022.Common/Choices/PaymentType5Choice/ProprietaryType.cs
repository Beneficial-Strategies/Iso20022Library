// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentType5Choice
{
    /// <summary>
    /// Payment type that is not included in a predefined list.
    /// </summary>
    [IsoId("_nQ0J4-kAEemV35DUs8L82Q")]
    [DisplayName("Proprietary Type")]
    public record ProprietaryType : PaymentType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("PrtryTp")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}

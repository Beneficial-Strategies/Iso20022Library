// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ErrorHandling1Choice
{
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_RZI7M9p-Ed-ak6NoX_4Aeg_-632950304")]
    [DisplayName("Proprietary")]
    public record Proprietary : ErrorHandling1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alphanumeric string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}

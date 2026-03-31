// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat1Choice
{
    /// <summary>
    /// Format expressed as a short identification.
    /// </summary>
    [IsoId("_Q4EOcdp-Ed-ak6NoX_4Aeg_287687502")]
    [DisplayName("Short Identification")]
    public record ShortIdentification : IdentificationFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an upper case alphanumeric string with a length of three characters.
        /// </summary>
        [IsoXmlTag("ShrtId")]
        [IsoSimpleType(IsoSimpleType.Exact3UpperCaseAlphaNumericText)]
        public required IsoExact3UpperCaseAlphaNumericText Value { get; init; }
    }
}

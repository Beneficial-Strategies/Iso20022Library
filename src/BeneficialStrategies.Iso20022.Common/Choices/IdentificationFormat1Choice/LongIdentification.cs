// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationFormat1Choice
{
    /// <summary>
    /// Format expressed as a long identification.
    /// </summary>
    [IsoId("_Q4EOctp-Ed-ak6NoX_4Aeg_1003151038")]
    [DisplayName("Long Identification")]
    public record LongIdentification : IdentificationFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 30 characters.
        /// </summary>
        [IsoXmlTag("LngId")]
        [IsoSimpleType(IsoSimpleType.Max30Text)]
        public required IsoMax30Text Value { get; init; }
    }
}

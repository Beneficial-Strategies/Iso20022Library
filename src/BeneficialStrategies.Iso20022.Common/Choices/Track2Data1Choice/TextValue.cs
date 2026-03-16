// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Track2Data1Choice
{
    /// <summary>
    /// Value of track 2 data expressed in text form.
    /// </summary>
    [IsoId("_cnIL8ZaOEemfCcEf5rVTyg")]
    [DisplayName("Text Value")]
    public record TextValue : Track2Data1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 37 characters.
        /// </summary>
        [IsoXmlTag("TxtVal")]
        [IsoSimpleType(IsoSimpleType.Max37Text)]
        [StringLength(maximumLength: 37, MinimumLength = 1)]
        public required IsoMax37Text Value { get; init; }
    }
}

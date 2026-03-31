// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification1Choice
{
    /// <summary>
    /// Other identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_AmCO0QbTEeqrW7Meu5r3kQ")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public record OtherIdentification : InstrumentIdentification1Choice_
    {
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_n3WSFQbTEeqrW7Meu5r3kQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Indicates the source of the identifier that represent the constituents of a custom basket.
        /// </summary>
        [IsoId("_n3WSFwbTEeqrW7Meu5r3kQ")]
        [DisplayName("Source")]
        [IsoXmlTag("Src")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Source { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AirportName1Choice
{
    /// <summary>
    /// Identifies an airport by means of its IATA identification code. Example: LHR.
    /// </summary>
    [IsoId("_SsSlJNp-Ed-ak6NoX_4Aeg_-939167147")]
    [DisplayName("Airport Code")]
    public record AirportCode : AirportName1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 6 characters.
        /// </summary>
        [IsoXmlTag("AirprtCd")]
        [IsoSimpleType(IsoSimpleType.Max6Text)]
        [StringLength(maximumLength: 6, MinimumLength = 1)]
        public required IsoMax6Text Value { get; init; }
    }
}

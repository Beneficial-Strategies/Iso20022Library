// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalRightThreshold1Choice
{
    /// <summary>
    /// Additional right granted to specify the minimum stake in share capital or cash value or number of security holders required to table resolutions.
    /// </summary>
    [IsoId("_RDrolNp-Ed-ak6NoX_4Aeg_2143895546")]
    [DisplayName("Additional Right Threshold")]
    public record AdditionalRightThreshold : AdditionalRightThreshold1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("AddtlRghtThrshld")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}

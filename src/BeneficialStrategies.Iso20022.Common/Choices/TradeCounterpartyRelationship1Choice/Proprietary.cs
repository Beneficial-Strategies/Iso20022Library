// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeCounterpartyRelationship1Choice
{
    /// <summary>
    /// Classification of the party relationship using a proprietary identification scheme.
    /// </summary>
    [IsoId("_01yXUCb_Ee2BYL6XeAmCWw")]
    [DisplayName("Proprietary")]
    public record Proprietary : TradeCounterpartyRelationship1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 100 characters.
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.Max100Text)]
        [StringLength(maximumLength: 100, MinimumLength = 1)]
        public required IsoMax100Text Value { get; init; }
    }
}

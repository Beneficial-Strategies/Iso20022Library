// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat4Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_XDu4s5j3EeWn2ur3BXxtdg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public record Identification : PledgeeFormat4Choice_
    {
        /// <summary>
        /// Additional information about the entity to which the financial instruments are pledged.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax30Text)]
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public IsoRestrictedFINMax30Text? Value { get; init; }

        /// <summary>
        /// Entity to which the financial instruments are pledged expressed as a code.
        /// </summary>
        [IsoId("_Sg8bOW_nEeSNvKTulh2IuA")]
        [DisplayName("Pledgee Type")]
        [IsoXmlTag("PldgeeTp")]
        public required PledgeeType1Code PledgeeType { get; init; }
    }
}

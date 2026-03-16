// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat1Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_Tq_ecE9kEeSn2-3swbRbzg")]
    [DisplayName("Identification")]
    public record Identification : PledgeeFormat1Choice_
    {
        /// <summary>
        /// Additional information about the entity to which the financial instruments are pledged.
        /// </summary>
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Value { get; init; }

        /// <summary>
        /// Entity to which the financial instruments are pledged expressed as a code.
        /// </summary>
        [IsoId("_iSB9IE9gEeSn2-3swbRbzg")]
        [DisplayName("Pledgee Type")]
        [IsoXmlTag("PldgeeTp")]
        public required PledgeeType1Code PledgeeType { get; init; }
    }
}

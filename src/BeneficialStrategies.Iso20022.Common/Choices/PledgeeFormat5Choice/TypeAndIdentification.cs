// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat5Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
    /// </summary>
    [IsoId("_YxN_4dLGEeiN28wlpBQScw")]
    [DisplayName("Type And Identification")]
    public record TypeAndIdentification : PledgeeFormat5Choice_
    {
        /// <summary>
        /// Identification of the entity to which the financial instruments are pledged, expressed as a BIC.
        /// </summary>
        [IsoId("_ZF5PYdLGEeiN28wlpBQScw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public required IsoAnyBICDec2014Identifier Identification { get; init; }

        /// <summary>
        /// Entity to which the financial instruments are pledged expressed as a code.
        /// </summary>
        [IsoId("_ZF5PY9LGEeiN28wlpBQScw")]
        [DisplayName("Pledgee Type")]
        [IsoXmlTag("PldgeeTp")]
        public required PledgeeType1Code PledgeeType { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat6Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
    /// </summary>
    [IsoId("_Z07sm_fVEeiNZp_PtLohLw")]
    [DisplayName("Type And Identification")]
    public partial record TypeAndIdentification : PledgeeFormat6Choice_
    {
        #nullable enable
        
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
        
        
        #nullable disable
        
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat3Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
    /// </summary>
    [IsoId("_9NxogTnZEeWV5sr121Fc8A")]
    [DisplayName("Type And Identification")]
    public partial record TypeAndIdentification : PledgeeFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the entity to which the financial instruments are pledged, expressed as a BIC.
        /// </summary>
        [IsoId("_ux_IoE9eEeSn2-3swbRbzg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Identification { get; init; } 
        
        /// <summary>
        /// Entity to which the financial instruments are pledged expressed as a code.
        /// </summary>
        [IsoId("_C2hN8E9fEeSn2-3swbRbzg")]
        [DisplayName("Pledgee Type")]
        [IsoXmlTag("PldgeeTp")]
        public required PledgeeType1Code PledgeeType { get; init; } 
        
        
        #nullable disable
        
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat1Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a proprietary type and narrative description.
    /// </summary>
    [IsoId("_z4ReQE9kEeSn2-3swbRbzg")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PledgeeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity.
        /// </summary>
        [IsoId("_JW1xJy7CEeSQQqw1BT_aMg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; } 
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_JW1xJS7CEeSQQqw1BT_aMg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification40 Type { get; init; } 
        
        
        #nullable disable
        
    }
}

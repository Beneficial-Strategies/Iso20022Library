// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PledgeeFormat6Choice
{
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged expressed as a proprietary type and narrative description.
    /// </summary>
    [IsoId("_Z07sn_fVEeiNZp_PtLohLw")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : PledgeeFormat6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_cdSQKZKQEeWHWpTQn1FFVg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification47 Type { get; init; } 
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity.
        /// </summary>
        [IsoId("_cdSQK5KQEeWHWpTQn1FFVg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
        [StringLength(maximumLength: 30 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax30Text? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}

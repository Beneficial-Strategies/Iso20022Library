// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat8Choice
{
    /// <summary>
    /// Place of safekeeping expressed with a propriety identification scheme.
    /// </summary>
    [IsoId("_k06gOR5iEeWDV95LUQhXCA")]
    [DisplayName("Proprietary")]
    public partial record Proprietary : SafekeepingPlaceFormat8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_G3fcIx78EeWW2ZT-VTzGvw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required GenericIdentification30 Type { get; init; } 
        
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_G3fcJR78EeWW2ZT-VTzGvw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification151Choice
{
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_ctD2YffSEeiNZp_PtLohLw")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification151Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_Wg9wptp-Ed-ak6NoX_4Aeg_-248384610")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax140Text Name { get; init; } 
        
        
        #nullable disable
        
    }
}

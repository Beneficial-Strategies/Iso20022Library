// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification45Choice
{
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    [IsoId("_idS_t-aOEd-q8fx_Zl_34A")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification45Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZcUWtp-Ed-ak6NoX_4Aeg_-1177692231")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; } 
        
        /// <summary>
        /// Postal address of the party.
        /// </summary>
        [IsoId("_PZleQNp-Ed-ak6NoX_4Aeg_670261447")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress1? Address { get; init; } 
        
        
        #nullable disable
        
    }
}

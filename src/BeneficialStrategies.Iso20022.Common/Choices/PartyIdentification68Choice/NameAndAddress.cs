// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification68Choice
{
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_AUMj1dokEeC60axPepSq7g_-2137965810")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification68Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_APRnkNokEeC60axPepSq7g_2005512130")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; } 
        
        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_APRnkdokEeC60axPepSq7g_1122278843")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public PostalAddress8? Address { get; init; } 
        
        
        #nullable disable
        
    }
}

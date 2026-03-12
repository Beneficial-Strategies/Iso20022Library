// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification205Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_osYgE46XEemzmeK8_tPygg")]
    [DisplayName("Natural Person")]
    public partial record NaturalPerson : PartyIdentification205Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_Zfz85T6CEemPvNTzinB5Vw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName1 NameAndAddress { get; init; } 
        
        /// <summary>
        /// CONCAT
        /// </summary>
        [IsoId("_Zfz85j6CEemPvNTzinB5Vw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required NaturalPersonIdentification1 Identification { get; init; } 
        
        
        #nullable disable
        
    }
}

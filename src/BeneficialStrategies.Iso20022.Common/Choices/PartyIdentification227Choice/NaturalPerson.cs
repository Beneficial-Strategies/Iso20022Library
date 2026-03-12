// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification227Choice
{
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_B1TxNK-mEemJ1NnLPsTFaw")]
    [DisplayName("Natural Person")]
    public partial record NaturalPerson : PartyIdentification227Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_VybPp7IGEemux5trsZcCpw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName1 NameAndAddress { get; init; } 
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_VybPpbIGEemux5trsZcCpw")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; } 
        
        /// <summary>
        /// Natural person local identification and type.
        /// </summary>
        [IsoId("_VybPprIGEemux5trsZcCpw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public NaturalPersonIdentification1? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}

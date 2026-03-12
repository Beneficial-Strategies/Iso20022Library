// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification227Choice
{
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_B1TxNa-mEemJ1NnLPsTFaw")]
    [DisplayName("Legal Person")]
    public partial record LegalPerson : PartyIdentification227Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name and address of the party.
        /// </summary>
        [IsoId("_-2COla-jEemJ1NnLPsTFaw")]
        [DisplayName("Name And Address")]
        [IsoXmlTag("NmAndAdr")]
        public required PersonName2 NameAndAddress { get; init; } 
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_-2COlq-jEemJ1NnLPsTFaw")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public IsoMax256Text? EmailAddress { get; init; } 
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_-2COl6-jEemJ1NnLPsTFaw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification198Choice_? Identification { get; init; } 
        
        
        #nullable disable
        
    }
}

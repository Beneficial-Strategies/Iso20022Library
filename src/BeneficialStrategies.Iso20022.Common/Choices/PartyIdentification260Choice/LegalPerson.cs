// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification260Choice
{
    /// <summary>
    /// Legal Person.
    /// </summary>
    [DisplayName("Legal Person")]
    public partial record LegalPerson : PartyIdentification260Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("LglPrsn")]
        public required OrganisationIdentification49 Value { get; init; } 
        
        
        #nullable disable
        
    }
}

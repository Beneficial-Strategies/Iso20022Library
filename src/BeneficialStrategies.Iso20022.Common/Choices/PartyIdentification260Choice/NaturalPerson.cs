// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification260Choice
{
    /// <summary>
    /// Natural Person.
    /// </summary>
    [DisplayName("Natural Person")]
    public partial record NaturalPerson : PartyIdentification260Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NtrlPrsn")]
        public required NaturalPersonIdentification5 Value { get; init; } 
        
        
        #nullable disable
        
    }
}

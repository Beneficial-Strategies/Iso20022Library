// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation4Choice
{
    /// <summary>
    /// Person.
    /// </summary>
    [DisplayName("Person")]
    public partial record Person : PersonOrOrganisation4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prsn")]
        public required GenericPersonIdentification1 Value { get; init; } 
        
        
        #nullable disable
        
    }
}

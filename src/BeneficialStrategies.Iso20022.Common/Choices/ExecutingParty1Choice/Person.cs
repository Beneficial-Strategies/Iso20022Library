// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExecutingParty1Choice
{
    /// <summary>
    /// Identification of a person.
    /// </summary>
    [IsoId("_Fhu_4ViJEea-d4CsgzjlAw")]
    [DisplayName("Person")]
    public partial record Person : ExecutingParty1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Branch where the trader is located.
        /// </summary>
        [IsoId("_elevo1yuEeWBopJHIRjb4g")]
        [DisplayName("Country Of Branch")]
        [IsoXmlTag("CtryOfBrnch")]
        public required CountryCode CountryOfBranch { get; init; } 
        
        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_elevoVyuEeWBopJHIRjb4g")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public required GenericPersonIdentification1 Other { get; init; } 
        
        
        #nullable disable
        
    }
}

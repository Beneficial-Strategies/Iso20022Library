// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestmentParty1Choice
{
    /// <summary>
    /// Identification of a person.
    /// </summary>
    [IsoId("__qnZ8FytEeWBopJHIRjb4g")]
    [DisplayName("Person")]
    public partial record Person : InvestmentParty1Choice_
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

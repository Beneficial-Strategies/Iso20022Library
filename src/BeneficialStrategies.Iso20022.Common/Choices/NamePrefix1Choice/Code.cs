// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NamePrefix1Choice
{
    /// <summary>
    /// Name prefix expressed as a code.
    /// </summary>
    [IsoId("_5MAtECiEEeKVDZ5HKjI6bg")]
    [DisplayName("Code")]
    public partial record Code : NamePrefix1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NamePrefix1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

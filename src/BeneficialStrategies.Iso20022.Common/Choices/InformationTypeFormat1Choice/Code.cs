// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InformationTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the information type required.
    /// </summary>
    [IsoId("_ORF9wCXbEeOFIcNWlDEvdQ")]
    [DisplayName("Code")]
    public partial record Code : InformationTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of information event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionInformationType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

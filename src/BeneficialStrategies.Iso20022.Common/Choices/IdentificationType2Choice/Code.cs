// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationType2Choice
{
    /// <summary>
    /// Type of identification is defined using a code.
    /// </summary>
    [IsoId("_Q-Und9p-Ed-ak6NoX_4Aeg_-1273591161")]
    [DisplayName("Code")]
    public partial record Code : IdentificationType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfIdentification1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

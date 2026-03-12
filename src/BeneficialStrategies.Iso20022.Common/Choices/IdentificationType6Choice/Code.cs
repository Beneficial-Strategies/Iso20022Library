// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IdentificationType6Choice
{
    /// <summary>
    /// Type of identification is defined using an ISO 20022 code.
    /// </summary>
    [IsoId("_QmCDQ9p-Ed-ak6NoX_4Aeg_-1872712499")]
    [DisplayName("Code")]
    public partial record Code : IdentificationType6Choice_
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

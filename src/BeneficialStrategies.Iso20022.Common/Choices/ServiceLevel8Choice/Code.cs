// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice
{
    /// <summary>
    /// Specifies a pre-agreed service or level of service between the parties, as published in an external service level code list.
    /// </summary>
    [IsoId("_QJa_zdp-Ed-ak6NoX_4Aeg_1912716972")]
    [DisplayName("Code")]
    public partial record Code : ServiceLevel8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external service level code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalServiceLevel1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

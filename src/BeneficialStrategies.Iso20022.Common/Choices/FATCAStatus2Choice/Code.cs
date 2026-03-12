// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FATCAStatus2Choice
{
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status expressed as a code.
    /// </summary>
    [IsoId("_wTJnMSCVEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public partial record Code : FATCAStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FATCAStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

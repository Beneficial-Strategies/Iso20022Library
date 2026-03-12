// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PensionSchemeType3Choice
{
    /// <summary>
    /// Type of pension policy, plan or scheme expressed as a code.
    /// </summary>
    [IsoId("_XqDlIelqEeuvhrZwLF0fDg")]
    [DisplayName("Code")]
    public partial record Code : PensionSchemeType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of pension scheme.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PensionSchemeType3Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

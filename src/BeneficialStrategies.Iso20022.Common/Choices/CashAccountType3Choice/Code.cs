// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAccountType3Choice
{
    /// <summary>
    /// Type of cash account expressed as a code.
    /// </summary>
    [IsoId("_Kvt74CCyEeWJd9HF2tO7BA")]
    [DisplayName("Code")]
    public partial record Code : CashAccountType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of cash account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CashAccountType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

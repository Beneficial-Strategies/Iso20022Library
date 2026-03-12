// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CreditLineType1Choice
{
    /// <summary>
    /// Type of the credit line, as published in an external purpose code list.
    /// </summary>
    [IsoId("_2T3LxYZ5Eee8r9VKRbnJSg")]
    [DisplayName("Code")]
    public partial record Code : CreditLineType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external credit line type code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code set published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCreditLineType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

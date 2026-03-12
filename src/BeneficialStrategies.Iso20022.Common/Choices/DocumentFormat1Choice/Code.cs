// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice
{
    /// <summary>
    /// Document format.
    /// </summary>
    [IsoId("_932rtXltEeG7BsjMvd1mEw_1631851618")]
    [DisplayName("Code")]
    public partial record Code : DocumentFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external document format code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalDocumentFormat1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

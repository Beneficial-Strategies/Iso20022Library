// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AdditionalRightCode1Choice
{
    /// <summary>
    /// Identifies the additional right code.
    /// </summary>
    [IsoId("_RDYtpNp-Ed-ak6NoX_4Aeg_1133173418")]
    [DisplayName("Code")]
    public partial record Code : AdditionalRightCode1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalRight1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

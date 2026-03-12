// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice
{
    /// <summary>
    /// Authentication channel expressed as an external ISO 20022 code.
    /// </summary>
    [IsoId("_U4Y95ZdgEea1K6JAcAwoVg")]
    [DisplayName("Code")]
    public partial record Code : AuthenticationChannel1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the transaction authentication channel, as published in an external authentication channel code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalAuthenticationChannel1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

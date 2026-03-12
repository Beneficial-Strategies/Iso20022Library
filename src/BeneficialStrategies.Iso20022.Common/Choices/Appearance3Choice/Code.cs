// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Appearance3Choice
{
    /// <summary>
    /// Appearance expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_dhNzEeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public partial record Code : Appearance3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the deliverability of a security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Appearance1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

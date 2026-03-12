// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LegalRestrictions5Choice
{
    /// <summary>
    /// Legal restrictions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_cp37YeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public partial record Code : LegalRestrictions5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regulatory restrictions applicable to a security.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LegalRestrictions2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.MaturityRedemptionType3Choice
{
    /// <summary>
    /// Maturity redemption type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_eFqj8eLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public partial record Code : MaturityRedemptionType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the type of redemption at maturity.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MaturityRedemptionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

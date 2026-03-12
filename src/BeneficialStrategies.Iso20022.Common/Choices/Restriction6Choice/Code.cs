// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Restriction6Choice
{
    /// <summary>
    /// Restrictions expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TJ-35NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public partial record Code : Restriction6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regulatory restrictions applicable to a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OwnershipLegalRestrictions1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

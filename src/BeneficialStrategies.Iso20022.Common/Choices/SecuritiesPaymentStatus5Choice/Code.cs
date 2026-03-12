// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesPaymentStatus5Choice
{
    /// <summary>
    /// Securities payment status expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_cgvT8znAEeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public partial record Code : SecuritiesPaymentStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the state of payment of a security at a particular time.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesPaymentStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

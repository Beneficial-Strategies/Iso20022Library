// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPaymentType1Choice
{
    /// <summary>
    /// Type of payment instrument expressed as a code.
    /// </summary>
    [IsoId("_AuoZYF8yEeicg40_9gK9vQ")]
    [DisplayName("Code")]
    public partial record Code : FundPaymentType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of payment instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundPaymentType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

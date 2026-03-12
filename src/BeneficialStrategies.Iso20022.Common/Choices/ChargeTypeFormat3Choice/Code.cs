// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeFormat3Choice
{
    /// <summary>
    /// Standard code to specify the type of charge.
    /// </summary>
    [IsoId("_SumZGQEcEeCQm6a_G2yO_w_-437463895")]
    [DisplayName("Code")]
    public partial record Code : ChargeTypeFormat3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Type of service for which a charge is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ChargeType17Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

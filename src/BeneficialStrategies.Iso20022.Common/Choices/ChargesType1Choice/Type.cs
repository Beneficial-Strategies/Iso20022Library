// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargesType1Choice
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_yW81UBrdEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    public partial record Type : ChargesType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies charges linked to the conveyance of goods.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required ChargeType8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

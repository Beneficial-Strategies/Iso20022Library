// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BidRangeType1Choice
{
    /// <summary>
    /// Bid range type expressed as a code value.
    /// </summary>
    [IsoId("_ZWOBQO3NEeqc-LCjwLsUVg")]
    [DisplayName("Code")]
    public partial record Code : BidRangeType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Types of acceptable bid range values.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BidRangeType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

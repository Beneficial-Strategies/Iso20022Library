// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TargetMarket1Choice
{
    /// <summary>
    /// Specifies whether the product is aimed at the target expressed as a code.
    /// </summary>
    [IsoId("_ItKLUDcTEeiIxKQErQxblg")]
    [DisplayName("Code")]
    public partial record Code : TargetMarket1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether a financial product is in scope of a target market parameter.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TargetMarket1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

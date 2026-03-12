// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BasisPriceType1Choice
{
    /// <summary>
    /// Basis price type is defined using a code.
    /// </summary>
    [IsoId("_RBTC9dp-Ed-ak6NoX_4Aeg_1196903751")]
    [DisplayName("Code")]
    public partial record Code : BasisPriceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Basis price type in a bid order. Used for list trading.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BasisPriceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

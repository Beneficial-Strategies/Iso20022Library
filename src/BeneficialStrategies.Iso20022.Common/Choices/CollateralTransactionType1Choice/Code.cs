// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralTransactionType1Choice
{
    /// <summary>
    /// Specifies the type of collateral instruction as a code.
    /// </summary>
    [IsoId("_xKnygLyzEeivTd4NUfCi2g")]
    [DisplayName("Code")]
    public partial record Code : CollateralTransactionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of collateral instruction as a code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CollateralTransactionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}

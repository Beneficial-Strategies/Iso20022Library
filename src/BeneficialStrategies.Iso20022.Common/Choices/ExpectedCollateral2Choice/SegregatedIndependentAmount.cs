// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral2Choice
{
    /// <summary>
    /// Provides the expected collateral type and direction for the segregated independent amount.
    /// </summary>
    [IsoId("_-sdWM4LZEeWrrO9HojbPQA")]
    [DisplayName("Segregated Independent Amount")]
    public partial record SegregatedIndependentAmount : ExpectedCollateral2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of collateral that will be delivered and date by which the collateral movement is expected.
        /// </summary>
        [IsoId("__cEOMYLZEeWrrO9HojbPQA")]
        [DisplayName("Delivery")]
        [IsoXmlTag("Dlvry")]
        public CollateralMovement9? Delivery { get; init; } 
        
        /// <summary>
        /// Type of collateral that will be returned and date by which the collateral movement is expected.
        /// </summary>
        [IsoId("__cEOM4LZEeWrrO9HojbPQA")]
        [DisplayName("Return")]
        [IsoXmlTag("Rtr")]
        public CollateralMovement9? Return { get; init; } 
        
        
        #nullable disable
        
    }
}

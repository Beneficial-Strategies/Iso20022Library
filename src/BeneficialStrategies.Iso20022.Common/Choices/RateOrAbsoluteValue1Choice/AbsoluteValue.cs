// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateOrAbsoluteValue1Choice
{
    /// <summary>
    /// Absolute value determined with a number.
    /// </summary>
    [IsoId("_RBcz8dp-Ed-ak6NoX_4Aeg_-1504048386")]
    [DisplayName("Absolute Value")]
    public partial record AbsoluteValue : RateOrAbsoluteValue1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("AbsVal")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StressSize1Choice
{
    /// <summary>
    /// Absolute shift if the shift is defined as an absolute move.
    /// </summary>
    [IsoId("_rwZwcKs1Eeayv9XxdmMwKQ")]
    [DisplayName("Absolute")]
    public partial record Absolute : StressSize1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unit of measure for the absolute stress.
        /// </summary>
        [IsoId("_wwCQEMBmEeak3I7j2hsibw")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Unit { get; init; } 
        
        /// <summary>
        /// Number of units of measure shifted.
        /// </summary>
        [IsoId("_12l6MMBmEeak3I7j2hsibw")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Quantity { get; init; } 
        
        
        #nullable disable
        
    }
}

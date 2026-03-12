// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>
    /// Upper boundary of a range of quantity values.
    /// </summary>
    [IsoId("_jtRfEe5NEeCisYr99QEiWA_44952824")]
    [DisplayName("To Quantity")]
    public partial record ToQuantity : QuantityRange1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity value of the range limit.
        /// </summary>
        [IsoId("_jtapAO5NEeCisYr99QEiWA_-330775982")]
        [DisplayName("Boundary")]
        [IsoXmlTag("Bdry")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Boundary { get; init; } 
        
        /// <summary>
        /// Indicates whether the boundary quantity is included in the range of quantity values.
        /// </summary>
        [IsoId("_jtapAe5NEeCisYr99QEiWA_279625946")]
        [DisplayName("Included")]
        [IsoXmlTag("Incl")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Included { get; init; } 
        
        
        #nullable disable
        
    }
}

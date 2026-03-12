// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice
{
    /// <summary>
    /// Range of valid quantity values.
    /// </summary>
    [IsoId("_jtRfEu5NEeCisYr99QEiWA_-1639886527")]
    [DisplayName("From To Quantity")]
    public partial record FromToQuantity : QuantityRange1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Lower boundary of a range of quantity values.
        /// </summary>
        [IsoId("_jtHuEu5NEeCisYr99QEiWA_-621671182")]
        [DisplayName("From Quantity")]
        [IsoXmlTag("FrQty")]
        public required QuantityRangeBoundary1 FromQuantity { get; init; } 
        
        /// <summary>
        /// Upper boundary of a range of quantity values.
        /// </summary>
        [IsoId("_jtHuE-5NEeCisYr99QEiWA_788676247")]
        [DisplayName("To Quantity")]
        [IsoXmlTag("ToQty")]
        public required QuantityRangeBoundary1 ToQuantity { get; init; } 
        
        
        #nullable disable
        
    }
}

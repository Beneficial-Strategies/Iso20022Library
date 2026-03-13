// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Quantity14Choice
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_QYSGhRgKEeKqWJINzXcn5g")]
    [DisplayName("Unit")]
    public partial record Unit : Quantity14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as a number, for example, a number of shares.
        /// </summary>
        [IsoId("_jQnpABgLEeKqWJINzXcn5g")]
        [DisplayName("Total Units Number")]
        [IsoXmlTag("TtlUnitsNb")]
        public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
        
        /// <summary>
        /// Information about the units to be transferred.
        /// </summary>
        [IsoId("_swUdoBgLEeKqWJINzXcn5g")]
        [DisplayName("Unit Details")]
        [IsoXmlTag("UnitDtls")]
        [MinLength(0)]
        [MaxLength(2)]
        public ValueList<Unit5> UnitDetails { get; init; } = [];
        
        
        #nullable disable
        
    }
}

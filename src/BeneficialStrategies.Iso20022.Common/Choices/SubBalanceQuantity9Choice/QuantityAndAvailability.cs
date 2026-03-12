// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity9Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance and whether the balance is available.
    /// </summary>
    [IsoId("_ciAo7zi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity And Availability")]
    public partial record QuantityAndAvailability : SubBalanceQuantity9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity of securities in the sub-balance.
        /// </summary>
        [IsoId("_ciApHTi8Eeydid5dcNPKvg")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 
        
        /// <summary>
        /// Indicates whether the quantity of securities on the sub-balance is available.
        /// </summary>
        [IsoId("_ciApHzi8Eeydid5dcNPKvg")]
        [DisplayName("Availability Indicator")]
        [IsoXmlTag("AvlbtyInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator AvailabilityIndicator { get; init; } 
        
        
        #nullable disable
        
    }
}

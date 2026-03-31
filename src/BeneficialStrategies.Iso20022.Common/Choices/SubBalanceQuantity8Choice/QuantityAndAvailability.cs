// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity8Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance and whether the balance is available.
    /// </summary>
    [IsoId("_k0vqcSp8EeyR9JrVGfaMKw")]
    [DisplayName("Quantity And Availability")]
    [IsoXmlTag("QtyAndAvlbty")]
    public record QuantityAndAvailability : SubBalanceQuantity8Choice_
    {
        /// <summary>
        /// Quantity of securities in the sub-balance.
        /// </summary>
        [IsoId("_u9HBgSp8EeyR9JrVGfaMKw")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; }

        /// <summary>
        /// Indicates whether the quantity of securities on the sub-balance is available.
        /// </summary>
        [IsoId("_u9HBgyp8EeyR9JrVGfaMKw")]
        [DisplayName("Availability Indicator")]
        [IsoXmlTag("AvlbtyInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator AvailabilityIndicator { get; init; }
    }
}

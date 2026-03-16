// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity2Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance and whether the balance is available.
    /// </summary>
    [IsoId("_QZhRRtp-Ed-ak6NoX_4Aeg_-1518979138")]
    [DisplayName("Quantity And Availability")]
    public record QuantityAndAvailability : SubBalanceQuantity2Choice_
    {
        /// <summary>
        /// Quantity of securities in the sub-balance.
        /// </summary>
        [IsoId("_QZhRSNp-Ed-ak6NoX_4Aeg_-987951353")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

        /// <summary>
        /// Indicates whether the quantity of securities on the sub-balance is available.
        /// </summary>
        [IsoId("_QZqbMNp-Ed-ak6NoX_4Aeg_-987951336")]
        [DisplayName("Availability Indicator")]
        [IsoXmlTag("AvlbtyInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator AvailabilityIndicator { get; init; }
    }
}

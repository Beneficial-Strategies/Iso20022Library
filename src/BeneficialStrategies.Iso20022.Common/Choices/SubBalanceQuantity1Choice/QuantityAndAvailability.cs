// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity1Choice
{
    /// <summary>
    /// Quantity of securities in the sub-balance and whether the balance is available.
    /// </summary>
    [IsoId("_QYn5a9p-Ed-ak6NoX_4Aeg_-1813987615")]
    [DisplayName("Quantity And Availability")]
    [IsoXmlTag("QtyAndAvlbty")]
    public record QuantityAndAvailability : SubBalanceQuantity1Choice_
    {
        /// <summary>
        /// Quantity of securities in the sub-balance.
        /// </summary>
        [IsoId("_QYxDUdp-Ed-ak6NoX_4Aeg_-1703164106")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantityChoice_ Quantity { get; init; }

        /// <summary>
        /// Indicates whether the quantity of securities on the sub-balance is available.
        /// </summary>
        [IsoId("_QYxDUtp-Ed-ak6NoX_4Aeg_-1460279725")]
        [DisplayName("Availability Indicator")]
        [IsoXmlTag("AvlbtyInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator AvailabilityIndicator { get; init; }
    }
}

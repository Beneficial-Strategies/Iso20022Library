// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ShipmentSchedule1Choice
{
    /// <summary>
    /// Specifies a shipment schedule, ie, quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_RcH9wdp-Ed-ak6NoX_4Aeg_-444169830")]
    [DisplayName("Shipment Sub Schedule")]
    public record ShipmentSubSchedule : ShipmentSchedule1Choice_
    {
        /// <summary>
        /// Sub quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
        /// </summary>
        [IsoId("_Sp5_htp-Ed-ak6NoX_4Aeg_-1202382015")]
        [DisplayName("Sub Quantity Value")]
        [IsoXmlTag("SubQtyVal")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber SubQuantityValue { get; init; }

        /// <summary>
        /// Earliest date whereby the goods must be shipped.
        /// </summary>
        [IsoId("_Sp5_h9p-Ed-ak6NoX_4Aeg_-876378095")]
        [DisplayName("Earliest Shipment Date")]
        [IsoXmlTag("EarlstShipmntDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? EarliestShipmentDate { get; init; }

        /// <summary>
        /// Latest date whereby the goods must be shipped.
        /// </summary>
        [IsoId("_SqDwgNp-Ed-ak6NoX_4Aeg_-1202381938")]
        [DisplayName("Latest Shipment Date")]
        [IsoXmlTag("LatstShipmntDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? LatestShipmentDate { get; init; }
    }
}

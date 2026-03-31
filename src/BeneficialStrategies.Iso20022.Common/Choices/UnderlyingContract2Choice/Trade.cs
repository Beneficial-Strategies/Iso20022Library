// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingContract2Choice
{
    /// <summary>
    /// Underlying registered contract is a commercial trade.
    /// </summary>
    [IsoId("_JgnYg249EeiU9cctagi5ow")]
    [DisplayName("Trade")]
    [IsoXmlTag("Trad")]
    public record Trade : UnderlyingContract2Choice_
    {
        /// <summary>
        /// Contract document referenced from this trade agreement.
        /// </summary>
        [IsoId("_KAgZgW49EeiU9cctagi5ow")]
        [DisplayName("Contract Document Identification")]
        [IsoXmlTag("CtrctDocId")]
        public DocumentIdentification22? ContractDocumentIdentification { get; init; }

        /// <summary>
        /// Amount of the trade contract.
        /// </summary>
        [IsoId("_KAgZg249EeiU9cctagi5ow")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Party that is specified as the buyer for this trade agreement.
        /// </summary>
        [IsoId("_KAgZhW49EeiU9cctagi5ow")]
        [DisplayName("Buyer")]
        [IsoXmlTag("Buyr")]
        public ValueList<TradeParty5> Buyer { get; init; } = [];

        // ID for the above is _KAgZhW49EeiU9cctagi5ow

        /// <summary>
        /// Party that is specified as the seller for this trade agreement.
        /// </summary>
        [IsoId("_KAgZh249EeiU9cctagi5ow")]
        [DisplayName("Seller")]
        [IsoXmlTag("Sellr")]
        public ValueList<TradeParty5> Seller { get; init; } = [];

        // ID for the above is _KAgZh249EeiU9cctagi5ow

        /// <summary>
        /// Planned final payment date at the time of issuance.
        /// </summary>
        [IsoId("_KAgZiW49EeiU9cctagi5ow")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Indicates whether the contract duration is extended or not.
        /// </summary>
        [IsoId("_KAgZi249EeiU9cctagi5ow")]
        [DisplayName("Prolongation Flag")]
        [IsoXmlTag("PrlngtnFlg")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator ProlongationFlag { get; init; }

        /// <summary>
        /// Start date of the trade contract.
        /// </summary>
        [IsoId("_KAgZjW49EeiU9cctagi5ow")]
        [DisplayName("Start Date")]
        [IsoXmlTag("StartDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate StartDate { get; init; }

        /// <summary>
        /// Currency in which the trade is being settled.
        /// </summary>
        [IsoId("_KAgZj249EeiU9cctagi5ow")]
        [DisplayName("Settlement Currency")]
        [IsoXmlTag("SttlmCcy")]
        public required ActiveCurrencyCode SettlementCurrency { get; init; }

        /// <summary>
        /// Provides details on the currency exchange rate and contract.
        /// </summary>
        [IsoId("_KAgZkW49EeiU9cctagi5ow")]
        [DisplayName("Exchange Rate Information")]
        [IsoXmlTag("XchgRateInf")]
        public ExchangeRate1? ExchangeRateInformation { get; init; }

        /// <summary>
        /// Schedule of the payments defined for the trade contract.
        /// </summary>
        [IsoId("_KAgZk249EeiU9cctagi5ow")]
        [DisplayName("Payment Schedule")]
        [IsoXmlTag("PmtSchdl")]
        public InterestPaymentDateRange1? PaymentSchedule { get; init; }

        /// <summary>
        /// Schedule of the shipment.
        /// </summary>
        [IsoId("_KAgZlW49EeiU9cctagi5ow")]
        [DisplayName("Shipment Schedule")]
        [IsoXmlTag("ShipmntSchdl")]
        public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; }

        /// <summary>
        /// Documents provided as attachments to the trade contract.
        /// </summary>
        [IsoId("_KAgZl249EeiU9cctagi5ow")]
        [DisplayName("Attachment")]
        [IsoXmlTag("Attchmnt")]
        public DocumentGeneralInformation3? Attachment { get; init; }
    }
}

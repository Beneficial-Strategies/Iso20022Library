// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery4Choice
{
    /// <summary>
    /// Query criteria specifically applied to ad-hoc queries.
    /// </summary>
    [IsoId("_QH0wcYeAEei-Poi-FosJdw")]
    [DisplayName("Ad Hoc Query")]
    public record AdHocQuery : TradeReportQuery4Choice_
    {
        /// <summary>
        /// Field to define whether the query response file will include all reports submitted for a trade [true]or only the current state of the trade [false].
        /// If false is selected, the reporting timestamp field cannot be used.
        /// </summary>
        [IsoId("_MepeI5QUEeiok48Eh9lW9Q")]
        [DisplayName("Trade Life Cycle History")]
        [IsoXmlTag("TradLifeCyclHstry")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; }

        /// <summary>
        /// Field to define whether if the query response file will include all trades or only the outstanding trades.
        /// </summary>
        [IsoId("_MepeJZQUEeiok48Eh9lW9Q")]
        [DisplayName("Outstanding Trade Indicator")]
        [IsoXmlTag("OutsdngTradInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; }

        /// <summary>
        /// Query criteria related to counterparties.
        /// </summary>
        [IsoId("_MepeJ5QUEeiok48Eh9lW9Q")]
        [DisplayName("Trade Party Criteria")]
        [IsoXmlTag("TradPtyCrit")]
        public TradePartyQueryCriteria3? TradePartyCriteria { get; init; }

        /// <summary>
        /// Indicates the query criteria related to financial instruments.
        /// </summary>
        [IsoId("_MepeKZQUEeiok48Eh9lW9Q")]
        [DisplayName("Financial Instrument Criteria")]
        [IsoXmlTag("FinInstrmCrit")]
        public TradeSecurityIdentificationQueryCriteria2? FinancialInstrumentCriteria { get; init; }

        /// <summary>
        /// Query criteria related to time values.
        /// </summary>
        [IsoId("_MepeK5QUEeiok48Eh9lW9Q")]
        [DisplayName("Time Criteria")]
        [IsoXmlTag("TmCrit")]
        public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; }

        /// <summary>
        /// Query criteria related to other fields.
        /// </summary>
        [IsoId("_MepeLZQUEeiok48Eh9lW9Q")]
        [DisplayName("Other Criteria")]
        [IsoXmlTag("OthrCrit")]
        public TradeAdditionalQueryCriteria3? OtherCriteria { get; init; }
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery12Choice
{
    /// <summary>
    /// Query criteria specifically applied to ad-hoc queries.
    /// </summary>
    [IsoId("_QG7ioa5pEeuo-IflVgGqiA")]
    [DisplayName("Ad Hoc Query")]
    public partial record AdHocQuery : TradeReportQuery12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates whether the response must include all reports submitted for a trade (true) or only the current state of the trade (false).
        /// Usage:
        /// If false is selected, the reporting timestamp element must be absent.
        /// </summary>
        [IsoId("_QWIcQa5pEeuo-IflVgGqiA")]
        [DisplayName("Trade Life Cycle History")]
        [IsoXmlTag("TradLifeCyclHstry")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
        
        /// <summary>
        /// Indicates whether the response must include all trades  (false) or only the outstanding trades (true).
        /// </summary>
        [IsoId("_QWIcQ65pEeuo-IflVgGqiA")]
        [DisplayName("Outstanding Trade Indicator")]
        [IsoXmlTag("OutsdngTradInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
        
        /// <summary>
        /// Query criteria related to counterparties.
        /// </summary>
        [IsoId("_QWIcRa5pEeuo-IflVgGqiA")]
        [DisplayName("Trade Party Criteria")]
        [IsoXmlTag("TradPtyCrit")]
        public TradePartyQueryCriteria5? TradePartyCriteria { get; init; } 
        
        /// <summary>
        /// Query criteria related to transaction types.
        /// </summary>
        [IsoId("_QWIcR65pEeuo-IflVgGqiA")]
        [DisplayName("Trade Type Criteria")]
        [IsoXmlTag("TradTpCrit")]
        public TradeTypeQueryCriteria1? TradeTypeCriteria { get; init; } 
        
        /// <summary>
        /// Query criteria related to time values.
        /// </summary>
        [IsoId("_QWIcSa5pEeuo-IflVgGqiA")]
        [DisplayName("Time Criteria")]
        [IsoXmlTag("TmCrit")]
        public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
        
        /// <summary>
        /// Query criteria related to other fields.
        /// </summary>
        [IsoId("_QWIcS65pEeuo-IflVgGqiA")]
        [DisplayName("Other Criteria")]
        [IsoXmlTag("OthrCrit")]
        public TradeAdditionalQueryCriteria7? OtherCriteria { get; init; } 
        
        
        #nullable disable
        
    }
}

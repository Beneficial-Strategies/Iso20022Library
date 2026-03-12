// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query criteria on a trade transaction.
/// </summary>
[IsoId("_noB-MWE3Ee2S65ml6YCOtA")]
[DisplayName("Trade Query Criteria")]
public partial record TradeQueryCriteria13
{
    #nullable enable
    
    /// <summary>
    /// Field to define whether the query response file will include all reports submitted for a trade [true]or only the current state of the trade [false].
    /// If false is selected, the reporting timestamp field cannot be used.
    /// </summary>
    [IsoId("_np18E2E3Ee2S65ml6YCOtA")]
    [DisplayName("Trade Life Cycle History")]
    [IsoXmlTag("TradLifeCyclHstry")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
    
    /// <summary>
    /// Field to define whether if the query response file will include all trades or only the outstanding trades.
    /// </summary>
    [IsoId("_np18FWE3Ee2S65ml6YCOtA")]
    [DisplayName("Outstanding Trade Indicator")]
    [IsoXmlTag("OutsdngTradInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
    
    /// <summary>
    /// Query criteria related to counterparties.
    /// </summary>
    [IsoId("_np18F2E3Ee2S65ml6YCOtA")]
    [DisplayName("Trade Party Criteria")]
    [IsoXmlTag("TradPtyCrit")]
    public TradePartyQueryCriteria6? TradePartyCriteria { get; init; } 
    
    /// <summary>
    /// Indicates the query criteria related to financial instruments.
    /// </summary>
    [IsoId("_np18GWE3Ee2S65ml6YCOtA")]
    [DisplayName("Financial Instrument Criteria")]
    [IsoXmlTag("FinInstrmCrit")]
    public TradeSecurityIdentificationQueryCriteria3? FinancialInstrumentCriteria { get; init; } 
    
    /// <summary>
    /// Query criteria related to time values.
    /// </summary>
    [IsoId("_np18G2E3Ee2S65ml6YCOtA")]
    [DisplayName("Time Criteria")]
    [IsoXmlTag("TmCrit")]
    public TradeDateTimeQueryCriteria5? TimeCriteria { get; init; } 
    
    /// <summary>
    /// Query criteria related to other fields.
    /// </summary>
    [IsoId("_np18HWE3Ee2S65ml6YCOtA")]
    [DisplayName("Other Criteria")]
    [IsoXmlTag("OthrCrit")]
    public TradeAdditionalQueryCriteria9? OtherCriteria { get; init; } 
    
    
    #nullable disable
    
}

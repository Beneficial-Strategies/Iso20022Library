// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by a user defined parameter/s.
/// </summary>
[IsoId("_RPwVtdp-Ed-ak6NoX_4Aeg_-1574438434")]
[DisplayName("Breakdown By User Defined Parameter")]
public partial record BreakdownByUserDefinedParameter1
{
    #nullable enable
    
    /// <summary>
    /// Party for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVttp-Ed-ak6NoX_4Aeg_745428729")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification2Choice_? Party { get; init; } 
    
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVt9p-Ed-ak6NoX_4Aeg_746348760")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVuNp-Ed-ak6NoX_4Aeg_746348838")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Parameter for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RP6GsNp-Ed-ak6NoX_4Aeg_746348898")]
    [DisplayName("User Defined")]
    [IsoXmlTag("UsrDfnd")]
    public DataFormat2Choice_? UserDefined { get; init; } 
    
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RP6Gsdp-Ed-ak6NoX_4Aeg_-1574438054")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public CashInForecast3? CashInForecast { get; init; } 
    
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RP6Gstp-Ed-ak6NoX_4Aeg_-1573517987")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public CashOutForecast3? CashOutForecast { get; init; } 
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the user defined parameter.
    /// </summary>
    [IsoId("_RP6Gs9p-Ed-ak6NoX_4Aeg_-1574438373")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public NetCashForecast2? NetCashForecast { get; init; } 
    
    
    #nullable disable
    
}

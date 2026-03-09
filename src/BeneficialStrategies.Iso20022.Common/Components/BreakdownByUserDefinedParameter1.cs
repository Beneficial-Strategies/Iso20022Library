// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by a user defined parameter/s.
/// </summary>
[IsoId("_RPwVtdp-Ed-ak6NoX_4Aeg_-1574438434")]
[DisplayName("Breakdown By User Defined Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BreakdownByUserDefinedParameter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVttp-Ed-ak6NoX_4Aeg_745428729")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? Party { get; init; } 
    #else
    public PartyIdentification2Choice_? Party { get; set; } 
    #endif
    
    /// <summary>
    /// Country for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVt9p-Ed-ak6NoX_4Aeg_746348760")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RPwVuNp-Ed-ak6NoX_4Aeg_746348838")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Parameter for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RP6GsNp-Ed-ak6NoX_4Aeg_746348898")]
    [DisplayName("User Defined")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrDfnd")]
    #endif
    [IsoXmlTag("UsrDfnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataFormat2Choice_? UserDefined { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataFormat2Choice_? UserDefined { get; init; } 
    #else
    public DataFormat2Choice_? UserDefined { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RP6Gsdp-Ed-ak6NoX_4Aeg_-1574438054")]
    [DisplayName("Cash In Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInFcst")]
    #endif
    [IsoXmlTag("CshInFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast3? CashInForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast3? CashInForecast { get; init; } 
    #else
    public CashInForecast3? CashInForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RP6Gstp-Ed-ak6NoX_4Aeg_-1573517987")]
    [DisplayName("Cash Out Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshOutFcst")]
    #endif
    [IsoXmlTag("CshOutFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast3? CashOutForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast3? CashOutForecast { get; init; } 
    #else
    public CashOutForecast3? CashOutForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the user defined parameter.
    /// </summary>
    [IsoId("_RP6Gs9p-Ed-ak6NoX_4Aeg_-1574438373")]
    [DisplayName("Net Cash Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetCshFcst")]
    #endif
    [IsoXmlTag("NetCshFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast2? NetCashForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast2? NetCashForecast { get; init; } 
    #else
    public NetCashForecast2? NetCashForecast { get; set; } 
    #endif
    
    
    #nullable disable
    
}

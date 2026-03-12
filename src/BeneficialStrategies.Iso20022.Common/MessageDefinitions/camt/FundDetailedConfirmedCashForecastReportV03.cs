// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.043.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund. If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.
/// The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.
/// In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement&apos;s underlying orders, such as commission and charges.
/// </summary>
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundDetailedConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings, sorted by country, institution name or other criteria defined by the user of one or more investment funds on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundDetailedConfirmedCashForecastReport is used to provide definitive cash movements, i.e., it is sent after the cut-off time and/or the price valuation of the fund. If the price is not yet definitive, then the FundDetailedEstimatedCashForecastReport message must be used.|The FundDetailedConfirmedCashForecastReport message is used to report cash movements in or out of a fund, organised by party, such as fund management company, country, currency or by some other criteria defined by the report provider. If the report is used to given the cash-in and cash-out for a party, then additional criteria, such as currency and country, can be specified.|In addition, the underlying transaction type for the cash-in or cash-out movement can be specified, as well as information about the cash movement's underlying orders, such as commission and charges.")]
[IsoId("_cUOjwtE-Ed-BzquC8wXy7w_151487021")]
[DisplayName("Fund Detailed Confirmed Cash Forecast Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundDetailedConfirmedCashForecastReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.043.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndDtldConfdCshFcstRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.043.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundDetailedConfirmedCashForecastReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundDetailedConfirmedCashForecastReportV03( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,FundCashForecast4 reqFundCashForecastDetails )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
        FundCashForecastDetails = reqFundCashForecastDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_cUOjw9E-Ed-BzquC8wXy7w_187174877")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_cUOjxNE-Ed-BzquC8wXy7w_-1114330808")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_cUOjxdE-Ed-BzquC8wXy7w_-1112482945")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_cUOjxtE-Ed-BzquC8wXy7w_-1110634478")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_cUYUwNE-Ed-BzquC8wXy7w_396376411")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination MessagePagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination MessagePagination { get; init; } 
    #else
    public Pagination MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_cUYUwdE-Ed-BzquC8wXy7w_-1299299787")]
    [DisplayName("Fund Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndCshFcstDtls")]
    #endif
    [IsoXmlTag("FndCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundCashForecast4 FundCashForecastDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundCashForecast4 FundCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundCashForecast4 FundCashForecastDetails { get; init; } 
    #else
    public FundCashForecast4 FundCashForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified in the fund cash forecast details.
    /// </summary>
    [IsoId("_cUYUwtE-Ed-BzquC8wXy7w_1853440922")]
    [DisplayName("Consolidated Net Cash Forecast")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsltdNetCshFcst")]
    #endif
    [IsoXmlTag("CnsltdNetCshFcst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; } 
    #else
    public NetCashForecast3? ConsolidatedNetCashForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_cUYUw9E-Ed-BzquC8wXy7w_-429341744")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since FundDetailedConfirmedCashForecastReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundDetailedConfirmedCashForecastReportV03.


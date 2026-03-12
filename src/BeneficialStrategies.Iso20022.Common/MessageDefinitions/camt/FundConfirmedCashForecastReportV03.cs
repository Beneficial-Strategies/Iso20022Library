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
/// This record is an implementation of the camt.041.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings of one or more investment funds on one or more trade dates.
/// The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.
/// Usage
/// The FundConfirmedCashForecastReport is used to report definitive cash movements, that is it is sent after the cut-off time and/or the price valuation of the fund.
/// This message contains incoming and outgoing cash flows that are confirmed, i.e., the price has been applied. If the price is not yet definitive, then the FundEstimatedCashForecastReport message must be used.
/// This message allows the report provider to report cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges.
/// If the report provider wishes to give detailed information related to cash movements, then the FundDetailedConfirmedCashForecastReport message must be used.
/// </summary>
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReport message to the report user, such as an investment manager, to report the confirmed cash incomings and outgoings of one or more investment funds on one or more trade dates.|The cash movements may result from, for example, redemption, subscription, switch transactions or reinvestment of dividends.|Usage|The FundConfirmedCashForecastReport is used to report definitive cash movements, that is it is sent after the cut-off time and/or the price valuation of the fund.|This message contains incoming and outgoing cash flows that are confirmed, i.e., the price has been applied. If the price is not yet definitive, then the FundEstimatedCashForecastReport message must be used.|This message allows the report provider to report cash movements in or out of a fund, but does not allow the Sender to categorise these movements, for example by country, or to give details of the underlying orders, commission or charges.|If the report provider wishes to give detailed information related to cash movements, then the FundDetailedConfirmedCashForecastReport message must be used.")]
[IsoId("_aWwxiNE-Ed-BzquC8wXy7w_1505542689")]
[DisplayName("Fund Confirmed Cash Forecast Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundConfirmedCashForecastReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.041.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndConfdCshFcstRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.041.001.03";
    
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
    /// Constructs a FundConfirmedCashForecastReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundConfirmedCashForecastReportV03( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,FundCashForecast3 reqFundCashForecastDetails )
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
    [IsoId("_aWwxidE-Ed-BzquC8wXy7w_-748935141")]
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
    [IsoId("_aWwxitE-Ed-BzquC8wXy7w_1377279054")]
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
    [IsoId("_aWwxi9E-Ed-BzquC8wXy7w_1387439752")]
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
    [IsoId("_aWwxjNE-Ed-BzquC8wXy7w_1390209182")]
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
    [IsoId("_aW57cNE-Ed-BzquC8wXy7w_1161053242")]
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
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund.
    /// </summary>
    [IsoId("_aW57cdE-Ed-BzquC8wXy7w_2145649395")]
    [DisplayName("Fund Cash Forecast Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndCshFcstDtls")]
    #endif
    [IsoXmlTag("FndCshFcstDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundCashForecast3 FundCashForecastDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundCashForecast3 FundCashForecastDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundCashForecast3 FundCashForecastDetails { get; init; } 
    #else
    public FundCashForecast3 FundCashForecastDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_aW57ctE-Ed-BzquC8wXy7w_1979573919")]
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
    [IsoId("_aW57c9E-Ed-BzquC8wXy7w_-340686957")]
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


// Since FundConfirmedCashForecastReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundConfirmedCashForecastReportV03.


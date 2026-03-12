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
/// This record is an implementation of the camt.044.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReportCancellation message to the report user, such as an investment manager, to cancel a previously sent FundConfirmedCashForecastReport message.
/// Usage
/// The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider. This message must contain reference to the of the message being cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|A report provider, such as a transfer agent, sends the FundConfirmedCashForecastReportCancellation message to the report user, such as an investment manager, to cancel a previously sent FundConfirmedCashForecastReport message.|Usage|The FundConfirmedCashForecastReportCancellation message is used to cancel an entire FundConfirmedCashForecastReport message that was previously sent by the report provider. This message must contain reference to the of the message being cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended.")]
[IsoId("_ZZ0BENE-Ed-BzquC8wXy7w_-1991627625")]
[DisplayName("Fund Confirmed Cash Forecast Report Cancellation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundConfirmedCashForecastReportCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.044.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndConfdCshFcstRptCxlV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.044.001.02";
    
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
    /// Constructs a FundConfirmedCashForecastReportCancellationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundConfirmedCashForecastReportCancellationV02( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_ZZ0BEdE-Ed-BzquC8wXy7w_-448915750")]
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
    [IsoId("_ZZ0BEtE-Ed-BzquC8wXy7w_-1991627238")]
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
    [IsoId("_ZZ0BE9E-Ed-BzquC8wXy7w_-1991627564")]
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
    [IsoId("_ZZ0BFNE-Ed-BzquC8wXy7w_-1991627605")]
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
    [IsoId("_ZZ0BFdE-Ed-BzquC8wXy7w_1327286073")]
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
    /// The FundDetailedConfirmedCashForecastReport to be cancelled.
    /// </summary>
    [IsoId("_ZZ0BFtE-Ed-BzquC8wXy7w_-1991627281")]
    [DisplayName("Cash Forecast Report To Be Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshFcstRptToBeCanc")]
    #endif
    [IsoXmlTag("CshFcstRptToBeCanc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundConfirmedCashForecastReport2? CashForecastReportToBeCancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundConfirmedCashForecastReport2? CashForecastReportToBeCancelled { get; init; } 
    #else
    public FundConfirmedCashForecastReport2? CashForecastReportToBeCancelled { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since FundConfirmedCashForecastReportCancellationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundConfirmedCashForecastReportCancellationV02.


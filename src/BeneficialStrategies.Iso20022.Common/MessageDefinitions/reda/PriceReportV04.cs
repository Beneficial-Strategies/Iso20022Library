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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE||A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.||USAGE||The PriceReport message is sent by the report provider to the report recipient to: |- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for other purposes than the execution of investment funds orders.|.
/// </summary>
[Description(@"SCOPE||A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReport message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to provide the net asset value and price information for financial instruments on specific trade dates and, optionally, to quote price variation information.||USAGE||The PriceReport message is sent by the report provider to the report recipient to: |- report prices for one or several different financial instruments for one or several different trade dates,|- report statistical information about the valuation of a financial instrument,|- inform another party that the quotation of a financial instrument is suspended,|- report prices that are used for other purposes than the execution of investment funds orders.|.")]
[IsoId("_IOkQsRj3EeKxeog5DTmtgg")]
[DisplayName("Price Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.001.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.001.001.04";
    
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
    /// Constructs a PriceReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceReportV04( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,System.String reqPriceReportIdentification,PriceReportFunction1Code reqFunction,PriceValuation4 reqPriceValuationDetails )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
        PriceReportIdentification = reqPriceReportIdentification;
        Function = reqFunction;
        PriceValuationDetails = reqPriceValuationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_IOkQtxj3EeKxeog5DTmtgg")]
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
    [IsoId("_IOkQuxj3EeKxeog5DTmtgg")]
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
    [IsoId("_IOkQvxj3EeKxeog5DTmtgg")]
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
    [IsoId("_IOkQwxj3EeKxeog5DTmtgg")]
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
    [IsoId("_IOkQxxj3EeKxeog5DTmtgg")]
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
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("__CwxkBl8EeKxsrht2duUcg")]
    [DisplayName("Price Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricRptId")]
    #endif
    [IsoXmlTag("PricRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PriceReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PriceReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PriceReportIdentification { get; init; } 
    #else
    public System.String PriceReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Function of the price report, that is, whether the price report is a new price report or a replacement of some kind.
    /// </summary>
    [IsoId("_TO56wBl9EeKxsrht2duUcg")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceReportFunction1Code Function { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceReportFunction1Code Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceReportFunction1Code Function { get; init; } 
    #else
    public PriceReportFunction1Code Function { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_CDo2sBl_EeKxsrht2duUcg")]
    [DisplayName("Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlId")]
    #endif
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationIdentification { get; init; } 
    #else
    public System.String? CancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_IOkQyxj3EeKxeog5DTmtgg")]
    [DisplayName("Price Valuation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricValtnDtls")]
    #endif
    [IsoXmlTag("PricValtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceValuation4 PriceValuationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceValuation4 PriceValuationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceValuation4 PriceValuationDetails { get; init; } 
    #else
    public PriceValuation4 PriceValuationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IOkQzxj3EeKxeog5DTmtgg")]
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


// Since PriceReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportV04.


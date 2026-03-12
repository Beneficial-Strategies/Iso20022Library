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



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The InvestmentFundReportRequest message is sent by a report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.
/// The Investment Fund Report Request message can be used to request one or many fund reference data report messages.
/// Usage
/// If the InvestmentFundReportRequest message is used to request a fund reference data report then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund reference data report that is specified as &quot;no criteria&quot; means that the request is a request for a reference data report messages for all funds.
/// </summary>
[Description(@"Scope|The InvestmentFundReportRequest message is sent by a report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.|The Investment Fund Report Request message can be used to request one or many fund reference data report messages.|Usage|If the InvestmentFundReportRequest message is used to request a fund reference data report then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund reference data report that is specified as ""no criteria"" means that the request is a request for a reference data report messages for all funds.")]
[IsoId("_qIk6YWolEeipaMTLlhaKMQ")]
[DisplayName("Investment Fund Report Request V")]
public partial record InvestmentFundReportRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvstmtFndRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_qIk6Y2olEeipaMTLlhaKMQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_qIk6ZWolEeipaMTLlhaKMQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_qIk6Z2olEeipaMTLlhaKMQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; } 
    
    /// <summary>
    /// Parameters for which the report is requested.
    /// </summary>
    [IsoId("_qIk6aWolEeipaMTLlhaKMQ")]
    [DisplayName("Report Request")]
    [IsoXmlTag("RptReq")]
    public required FundParameters4Choice_ ReportRequest { get; init; } 
    
    
    #nullable disable
    
}


// Since InvestmentFundReportRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvestmentFundReportRequestV03.


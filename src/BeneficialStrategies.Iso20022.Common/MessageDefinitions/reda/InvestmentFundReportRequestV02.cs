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
/// This record is an implementation of the reda.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party sends the InvestmentFundReportRequest message to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.
/// The InvestmentFundReportRequest message can be used to request one or many fund processing passport reports.
/// Usage
/// If the InvestmentFundReportRequest message is used to request a fund processing passport then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund processing passport report that is specified as &quot;no criteria&quot; means that the request is a request for all fund processing passports.
/// </summary>
[Description(@"Scope|A report user, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party sends the InvestmentFundReportRequest message to the report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to request a report.|The InvestmentFundReportRequest message can be used to request one or many fund processing passport reports.|Usage|If the InvestmentFundReportRequest message is used to request a fund processing passport then the request can specify the financial instrument for which the report is requested. Other appropriate parameters can also be included. It is also possible to indicate that the request is an open request, that is, there is no specific criteria for the report requested. For example, a request for a fund processing passport report that is specified as ""no criteria"" means that the request is a request for all fund processing passports.")]
[IsoId("_Zsax2NEvEd-BzquC8wXy7w_-630681424")]
[DisplayName("Investment Fund Report Request V")]
public partial record InvestmentFundReportRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvstmtFndRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.005.001.02";
    
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
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Zsax2dEvEd-BzquC8wXy7w_-760876160")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Zsax2tEvEd-BzquC8wXy7w_62177576")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Zsax29EvEd-BzquC8wXy7w_1615234816")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Parameters for which the fund processing passport report is requested.
    /// </summary>
    [IsoId("_Zsax3NEvEd-BzquC8wXy7w_436796647")]
    [DisplayName("Fund Processing Passport Report")]
    [IsoXmlTag("FPPRpt")]
    public required FundParameters3Choice_ FundProcessingPassportReport { get; init; } 
    
    
    #nullable disable
    
}


// Since InvestmentFundReportRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvestmentFundReportRequestV02.


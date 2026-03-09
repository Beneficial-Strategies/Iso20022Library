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


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.045.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer&apos;s agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.
/// </summary>
[Description(@"The ShareholdersIdentificationDisclosureRequest message is sent by an issuer or by a third party nominated by the issuer (such as an issuer's agent) to the first intermediaries in a custody chain or is sent by any intermediaries in a custody chain to the next intermediary down the chain of intermediaries (towards the investor side of the chain) in order to request the disclosure of shareholders identity and provides information on the receiving party to whom responses must be sent, on the financial instrument concerned and on the deadline to respond.")]
[IsoId("_n1QvATWfEe2OzdGcZrUAEQ")]
[DisplayName("Shareholders Identification Disclosure Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShareholdersIdentificationDisclosureRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.045.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.045.001.04";
    
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
    /// Constructs a ShareholdersIdentificationDisclosureRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShareholdersIdentificationDisclosureRequestV04( System.String reqIssuerDisclosureRequestIdentification,DisclosureRequestType1Code reqDisclosureRequestType,SecurityIdentification19 reqFinancialInstrumentIdentification,DateFormat46Choice_ reqShareholdersDisclosureRecordDate,PartyIdentification214 reqDisclosureResponseRecipient,DateFormat46Choice_ reqIssuerDisclosureDeadline )
    {
        IssuerDisclosureRequestIdentification = reqIssuerDisclosureRequestIdentification;
        DisclosureRequestType = reqDisclosureRequestType;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        ShareholdersDisclosureRecordDate = reqShareholdersDisclosureRecordDate;
        DisclosureResponseRecipient = reqDisclosureResponseRecipient;
        IssuerDisclosureDeadline = reqIssuerDisclosureDeadline;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Official and unique identification assigned to a shareholder identification disclosure request process by the issuer or third party nominated by it.
    /// </summary>
    [IsoId("_n1QvCzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Issuer Disclosure Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDsclsrReqId")]
    #endif
    [IsoXmlTag("IssrDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerDisclosureRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerDisclosureRequestIdentification { get; init; } 
    #else
    public System.String IssuerDisclosureRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of disclosure request.
    /// </summary>
    [IsoId("_n1QvDTWfEe2OzdGcZrUAEQ")]
    [DisplayName("Disclosure Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsclsrReqTp")]
    #endif
    [IsoXmlTag("DsclsrReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DisclosureRequestType1Code DisclosureRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisclosureRequestType1Code DisclosureRequestType { get; init; } 
    #else
    public DisclosureRequestType1Code DisclosureRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent shareholder identification disclosure request message.
    /// </summary>
    [IsoId("_n1QvDzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Previous Disclosure Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsDsclsrReqId")]
    #endif
    [IsoXmlTag("PrvsDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PreviousDisclosureRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousDisclosureRequestIdentification { get; init; } 
    #else
    public System.String? PreviousDisclosureRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the request is to be forwarded to and responded by the other intermediaries down the chain of intermediaries or not. If the request is not to be forwarded, the indicator may not be present.
    /// </summary>
    [IsoId("_n1QvETWfEe2OzdGcZrUAEQ")]
    [DisplayName("Forward Request Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdReqInd")]
    #endif
    [IsoXmlTag("FwdReqInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ForwardRequestIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForwardRequestIndicator { get; init; } 
    #else
    public System.String? ForwardRequestIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the shareholder identification disclosure response is to be sent back down the chain of intermediaries or directly to the identified response recipient. 
    /// If &quot;true&quot; or &quot;1&quot;, the response must be sent back through the chain of intermediaries.
    /// If &quot;false&quot; or &quot;0&quot; or if the indicator is not present, the response must be sent directly to the identified response recipient.
    /// </summary>
    [IsoId("_n1QvEzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Response Through Chain Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnThrghChainInd")]
    #endif
    [IsoXmlTag("RspnThrghChainInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ResponseThroughChainIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResponseThroughChainIndicator { get; init; } 
    #else
    public System.String? ResponseThroughChainIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the request was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_n1QvFTWfEe2OzdGcZrUAEQ")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrRghtsDrctvInd")]
    #endif
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShareholderRightsDirectiveIndicator { get; init; } 
    #else
    public System.String? ShareholderRightsDirectiveIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Governing law or place of jurisdiction where the disclosure request relates to. 
    /// </summary>
    [IsoId("_GcnS0DWgEe2OzdGcZrUAEQ")]
    [DisplayName("Place Of Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfJursdctn")]
    #endif
    [IsoXmlTag("PlcOfJursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfJurisdiction { get; init; } 
    #else
    public string? PlaceOfJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the law which relates to the disclosure request.
    /// </summary>
    [IsoId("_qJ2yYDWgEe2OzdGcZrUAEQ")]
    [DisplayName("Applicable Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblLaw")]
    #endif
    [IsoXmlTag("AplblLaw")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ApplicableLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicableLaw { get; init; } 
    #else
    public System.String? ApplicableLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_n1QvFzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date set by the issuer on which the shareholders identity is determined based on the settled positions struck in the books of the issuer CSD or any other first intermediary at the close of business day. 
    /// </summary>
    [IsoId("_n1QvGTWfEe2OzdGcZrUAEQ")]
    [DisplayName("Shareholders Disclosure Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrsDsclsrRcrdDt")]
    #endif
    [IsoXmlTag("ShrhldrsDsclsrRcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #else
    public DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of shares held by a shareholder above which the identification must be disclosed.
    /// </summary>
    [IsoId("_n1QvGzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Shares Quantity Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrsQtyThrshld")]
    #endif
    [IsoXmlTag("ShrsQtyThrshld")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? SharesQuantityThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SharesQuantityThreshold { get; init; } 
    #else
    public System.UInt64? SharesQuantityThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the date from which the shares have been held must be communicated into the disclosure response and according to which method theses dates have to be communicated. The method can be provided either with a predefined code or via a textual description.
    /// </summary>
    [IsoId("_n1QvHTWfEe2OzdGcZrUAEQ")]
    [DisplayName("Request Share Held Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqShrHeldDt")]
    #endif
    [IsoXmlTag("ReqShrHeldDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; init; } 
    #else
    public RequestShareHeldDate1Choice_? RequestShareHeldDate { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer or third party nominated by the issuer to whom the disclosure response shall be transmitted by the intermediary.
    /// </summary>
    [IsoId("_n1QvHzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Disclosure Response Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsclsrRspnRcpt")]
    #endif
    [IsoXmlTag("DsclsrRspnRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification214 DisclosureResponseRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification214 DisclosureResponseRecipient { get; init; } 
    #else
    public PartyIdentification214 DisclosureResponseRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Latest date/time set by the issuer or  a third party appointed by the issuer at which a response to the request to disclose shareholder identity shall be provided by each intermediary to the recipient to whom the response must be sent.  
    /// </summary>
    [IsoId("_n1QvITWfEe2OzdGcZrUAEQ")]
    [DisplayName("Issuer Disclosure Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDsclsrDdln")]
    #endif
    [IsoXmlTag("IssrDsclsrDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat46Choice_ IssuerDisclosureDeadline { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat46Choice_ IssuerDisclosureDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat46Choice_ IssuerDisclosureDeadline { get; init; } 
    #else
    public DateFormat46Choice_ IssuerDisclosureDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Latest date/time set by an intermediary at which a response to the request to disclose shareholder identity shall be provided when sending the response though the chain of intermediaries.  
    /// </summary>
    [IsoId("_n1QvIzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Disclosure Response Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsclsrRspnDdln")]
    #endif
    [IsoXmlTag("DsclsrRspnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat46Choice_? DisclosureResponseDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat46Choice_? DisclosureResponseDeadline { get; init; } 
    #else
    public DateFormat46Choice_? DisclosureResponseDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_n1QvJTWfEe2OzdGcZrUAEQ")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification129Choice_? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_n1QvJzWfEe2OzdGcZrUAEQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ShareholdersIdentificationDisclosureRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholdersIdentificationDisclosureRequestV04.


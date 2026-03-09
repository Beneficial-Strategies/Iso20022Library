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
/// This record is an implementation of the reda.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.
/// Usage
/// A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its &quot;home&quot; market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.
/// The FundReferenceDataReport message may be used in various models or environments:
/// -	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.
/// -	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.
/// -	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.
/// The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) versions 1 and 2.
/// </summary>
[Description(@"Scope|The FundReferenceDataReport message is sent by a report provider, for example, a fund promoter, fund management company, transfer agent, or market data provider to the report recipient, for example, a professional investor, investment fund distributor, market data provider, regulator or other interested party, to provide the key reference data for financial instruments to facilitate trading. The message may also include reporting data concerning product governance, such as target market data, and a breakdown of the costs and fees.|Usage|A FundReferenceDataReport message should be prepared for each class of unit/share (for which an individual ISIN should have been allocated), in respect of its ""home"" market. Each time the fund data changes, the ‘product provider’ must provide the data to a product user, for example, the distributors, by sending a new funds reference data report. A single message may contain more than one report. When the FundReferenceDataReport message is sent to provide updated reference data, the message overwrites the previously sent data.|The FundReferenceDataReport message may be used in various models or environments:|-	in a standalone environment, for example, initiated by the Report Provider (fund promoter, fund manager and / or reference data vendors) sent on a regular frequency, or when changes are needed.|-	in a request / response environment, with the InvestmentFundReportRequest, for example, initiated by report users (data vendors, professional investors, regulators or investment fund distributors) in enabling the user to control the flow and updates of information.|-	in a reference data vendor environment, for example, market infrastructure and reference data providers may collate and store all fund reference data information centrally for access via database or regular distribution information. A reference data vendor may assume the role of both report provider and report user.|The FundReferenceDataReport message may be used to provide data concerning product governance, such as target market data, and a breakdown of the costs and fees in the context of MiFID II, with respect to the European MiFID Template (EMT) versions 1 and 2.")]
[IsoId("_16QE0ZDiEem7fvtoGpNpow")]
[DisplayName("Fund Reference Data Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundReferenceDataReportV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.004.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FndRefDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.004.001.04";
    
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
    /// Constructs a FundReferenceDataReportV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundReferenceDataReportV04( MessageIdentification1 reqMessageIdentification,FundReferenceDataReport2 reqReport )
    {
        MessageIdentification = reqMessageIdentification;
        Report = reqReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_16QE05DiEem7fvtoGpNpow")]
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
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_16QE1ZDiEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? PreviousReference { get; init; } 
    #else
    public AdditionalReference10? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_16QE15DiEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? RelatedReference { get; init; } 
    #else
    public AdditionalReference10? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund reference data report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_16QE2ZDiEem7fvtoGpNpow")]
    [DisplayName("Fund Reference Data Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndRefDataRptId")]
    #endif
    [IsoXmlTag("FndRefDataRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FundReferenceDataReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FundReferenceDataReportIdentification { get; init; } 
    #else
    public System.String? FundReferenceDataReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Fund reference data.
    /// </summary>
    [IsoId("_16QE25DiEem7fvtoGpNpow")]
    [DisplayName("Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rpt")]
    #endif
    [IsoXmlTag("Rpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundReferenceDataReport2 Report { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundReferenceDataReport2 Report { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundReferenceDataReport2 Report { get; init; } 
    #else
    public FundReferenceDataReport2 Report { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since FundReferenceDataReportV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FundReferenceDataReportV04.


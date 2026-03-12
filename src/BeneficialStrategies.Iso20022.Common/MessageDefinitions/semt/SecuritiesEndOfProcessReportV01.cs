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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.
/// It may also be sent through Central Matching Utility (CMU).
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Executing Party, CMU or Instructing Party
/// Respondent: Custodian or an affirming party does not need to respond.
/// </summary>
[Description(@"Scope|Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.|It may also be sent through Central Matching Utility (CMU).|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Executing Party, CMU or Instructing Party|Respondent: Custodian or an affirming party does not need to respond.")]
[IsoId("_CwVqwOQXEeCGktPI9k4Dlw_-1232982722")]
[DisplayName("Securities End Of Process Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesEndOfProcessReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesEndOfPrcRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.023.001.01";
    
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
    /// Constructs a SecuritiesEndOfProcessReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesEndOfProcessReportV01( Report3 reqReportGeneralDetails )
    {
        ReportGeneralDetails = reqReportGeneralDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_CwVqweQXEeCGktPI9k4Dlw_552533910")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_CwVqwuQXEeCGktPI9k4Dlw_1253691050")]
    [DisplayName("Report General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptGnlDtls")]
    #endif
    [IsoXmlTag("RptGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Report3 ReportGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Report3 ReportGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Report3 ReportGeneralDetails { get; init; } 
    #else
    public Report3 ReportGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_CwfbwOQXEeCGktPI9k4Dlw_-1313694772")]
    [DisplayName("Confirmation Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPties")]
    #endif
    [IsoXmlTag("ConfPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationParties2? ConfirmationParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationParties2? ConfirmationParties { get; init; } 
    #else
    public ConfirmationParties2? ConfirmationParties { get; set; } 
    #endif
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_CwfbweQXEeCGktPI9k4Dlw_-582829199")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #else
    public PartyIdentificationAndAccount79? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CwfbwuQXEeCGktPI9k4Dlw_603070920")]
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


// Since SecuritiesEndOfProcessReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesEndOfProcessReportV01.


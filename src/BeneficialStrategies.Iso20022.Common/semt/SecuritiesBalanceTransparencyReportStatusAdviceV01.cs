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
/// This record is an implementation of the semt.042.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// 
/// An account owner, such as a custodian, central securities depository, international securities depository or transfer agent, sends the SecuritiesBalanceTransparencyReportStatusAdvice message in response to a SecuritiesBalanceTransparencyReport, to accept or reject the statement of holdings as sent in a SecuritiesBalanceTransparencyReport.
/// 
/// USAGE
/// The SecuritiesBalanceTransparencyReportStatusAdvice is used to accept (Accepted), partially accept (Accepted With Exception) or reject (Rejected) a previously received SecuritiesBalanceTransparencyReport.
/// </summary>
[Description(@"SCOPE||An account owner, such as a custodian, central securities depository, international securities depository or transfer agent, sends the SecuritiesBalanceTransparencyReportStatusAdvice message in response to a SecuritiesBalanceTransparencyReport, to accept or reject the statement of holdings as sent in a SecuritiesBalanceTransparencyReport.||USAGE|The SecuritiesBalanceTransparencyReportStatusAdvice is used to accept (Accepted), partially accept (Accepted With Exception) or reject (Rejected) a previously received SecuritiesBalanceTransparencyReport.")]
[IsoId("_yMxXsbvVEeOgOuxYpBEzKg")]
[DisplayName("Securities Balance Transparency Report Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesBalanceTransparencyReportStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.042.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalTrnsprncyRptStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.042.001.01";
    
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
    /// Constructs a SecuritiesBalanceTransparencyReportStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesBalanceTransparencyReportStatusAdviceV01( MessageIdentification1 reqMessageIdentification,PartyIdentification100 reqSenderIdentification,StatementReference1 reqRelatedStatement,ReportItemStatus1Choice_ reqStatus )
    {
        MessageIdentification = reqMessageIdentification;
        SenderIdentification = reqSenderIdentification;
        RelatedStatement = reqRelatedStatement;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the status advice message.
    /// </summary>
    [IsoId("_mBk7IU1qEeSvz4A_x0ui8g")]
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
    /// Identification of the party that is the sender of the status advice message.
    /// </summary>
    [IsoId("_pGGcEk1qEeSvz4A_x0ui8g")]
    [DisplayName("Sender Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrId")]
    #endif
    [IsoXmlTag("SndrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification100 SenderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification100 SenderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100 SenderIdentification { get; init; } 
    #else
    public PartyIdentification100 SenderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that is the receiver of the status advice message.
    /// </summary>
    [IsoId("_pGGcE01qEeSvz4A_x0ui8g")]
    [DisplayName("Receiver Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrId")]
    #endif
    [IsoXmlTag("RcvrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? ReceiverIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? ReceiverIdentification { get; init; } 
    #else
    public PartyIdentification100? ReceiverIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the statement for which the status advice has been issued.
    /// </summary>
    [IsoId("_x8GCwk4iEeSGlfauTkCKIA")]
    [DisplayName("Related Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdStmt")]
    #endif
    [IsoXmlTag("RltdStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementReference1 RelatedStatement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementReference1 RelatedStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementReference1 RelatedStatement { get; init; } 
    #else
    public StatementReference1 RelatedStatement { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the referenced statement.
    /// </summary>
    [IsoId("_SOA1Ir3PEeO2FLWuu_JIqg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportItemStatus1Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportItemStatus1Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportItemStatus1Choice_ Status { get; init; } 
    #else
    public ReportItemStatus1Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Number of items for each identical transaction status.
    /// </summary>
    [IsoId("_2EcUQUioEeSlHoYg_EudVQ")]
    [DisplayName("Number Of Items Per Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfItmsPerSts")]
    #endif
    [IsoXmlTag("NbOfItmsPerSts")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<NumberOfItemsPerStatus1> NumberOfItemsPerStatus { get; init; } = new ValueList<NumberOfItemsPerStatus1>(){};
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_SOA1I73PEeO2FLWuu_JIqg")]
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


// Since SecuritiesBalanceTransparencyReportStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesBalanceTransparencyReportStatusAdviceV01.


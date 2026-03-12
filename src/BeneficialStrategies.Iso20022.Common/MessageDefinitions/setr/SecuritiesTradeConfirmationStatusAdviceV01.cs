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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.044.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: In central matching the Initiator is the Central Matching Utility.
/// Respondent: no response is needed by the recipient of the message.
/// </summary>
[Description(@"Scope|This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The ISO 20022 Business Application Header must be used|Usage|Initiator: In central matching the Initiator is the Central Matching Utility.|Respondent: no response is needed by the recipient of the message.")]
[IsoId("_R0gNheQXEeCGktPI9k4Dlw_2456602")]
[DisplayName("Securities Trade Confirmation Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeConfirmationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.044.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.044.001.01";
    
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
    /// Constructs a SecuritiesTradeConfirmationStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeConfirmationStatusAdviceV01( TransactiontIdentification4 reqIdentification,Linkages18 reqReferences )
    {
        Identification = reqIdentification;
        References = reqReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationStatusAdvice message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_R0gNhuQXEeCGktPI9k4Dlw_1519100634")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactiontIdentification4 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactiontIdentification4 Identification { get; init; } 
    #else
    public TransactiontIdentification4 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_R0gNh-QXEeCGktPI9k4Dlw_1063314509")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Linkages18 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Linkages18 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages18 References { get; init; } 
    #else
    public Linkages18 References { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the affitrmation status of a trade.
    /// </summary>
    [IsoId("_R0p-gOQXEeCGktPI9k4Dlw_1323761257")]
    [DisplayName("Affirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffirmSts")]
    #endif
    [IsoXmlTag("AffirmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AffirmationStatus6Choice_? AffirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AffirmationStatus6Choice_? AffirmationStatus { get; init; } 
    #else
    public AffirmationStatus6Choice_? AffirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the processing status of a trade.
    /// </summary>
    [IsoId("_R0p-geQXEeCGktPI9k4Dlw_-1888119231")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus17Choice_? ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus17Choice_? ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus17Choice_? ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the matching status of a trade.
    /// </summary>
    [IsoId("_R0p-guQXEeCGktPI9k4Dlw_336194724")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus9Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus9Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus9Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the replacement processing status of a trade.
    /// </summary>
    [IsoId("_R0p-g-QXEeCGktPI9k4Dlw_-1103109076")]
    [DisplayName("Replacement Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RplcmntPrcgSts")]
    #endif
    [IsoXmlTag("RplcmntPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReplacementProcessingStatus7Choice_? ReplacementProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReplacementProcessingStatus7Choice_? ReplacementProcessingStatus { get; init; } 
    #else
    public ReplacementProcessingStatus7Choice_? ReplacementProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the cancellation status of a trade.
    /// </summary>
    [IsoId("_R0p-hOQXEeCGktPI9k4Dlw_-1182200619")]
    [DisplayName("Cancellation Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlPrcgSts")]
    #endif
    [IsoXmlTag("CxlPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationProcessingStatus6Choice_? CancellationProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationProcessingStatus6Choice_? CancellationProcessingStatus { get; init; } 
    #else
    public CancellationProcessingStatus6Choice_? CancellationProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trading party.
    /// </summary>
    [IsoId("_R0p-heQXEeCGktPI9k4Dlw_1766193623")]
    [DisplayName("Party Trading Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyTradgDtls")]
    #endif
    [IsoXmlTag("PtyTradgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Order16? PartyTradingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Order16? PartyTradingDetails { get; init; } 
    #else
    public Order16? PartyTradingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the trading counterparty.
    /// </summary>
    [IsoId("_R0zvgOQXEeCGktPI9k4Dlw_1093600034")]
    [DisplayName("Counterparty Trading Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyTradgDtls")]
    #endif
    [IsoXmlTag("CtrPtyTradgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Order16? CounterpartyTradingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Order16? CounterpartyTradingDetails { get; init; } 
    #else
    public Order16? CounterpartyTradingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parties used for acting parties that applies either to the whole message or to individual sides.
    /// </summary>
    [IsoId("_R0zvgeQXEeCGktPI9k4Dlw_660966103")]
    [DisplayName("Confirmation Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPties")]
    #endif
    [IsoXmlTag("ConfPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationParties4? ConfirmationParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationParties4? ConfirmationParties { get; init; } 
    #else
    public ConfirmationParties4? ConfirmationParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_R0zvguQXEeCGktPI9k4Dlw_-390382216")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties23? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_R0zvg-QXEeCGktPI9k4Dlw_1254885219")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties23? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties23? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties23? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_R0zvhOQXEeCGktPI9k4Dlw_1454821028")]
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


// Since SecuritiesTradeConfirmationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationStatusAdviceV01.


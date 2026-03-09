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
/// This record is an implementation of the setr.030.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.
/// Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.
/// </summary>
[Description(@"Scope|Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.|Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.")]
[IsoId("_QZAf5eQXEeCGktPI9k4Dlw_433053053")]
[DisplayName("Securities Trade Confirmation Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeConfirmationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.030.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.030.001.01";
    
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
    /// Constructs a SecuritiesTradeConfirmationResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeConfirmationResponseV01( TransactiontIdentification4 reqIdentification,Linkages15 reqReferences,StatusAndReason10 reqStatus )
    {
        Identification = reqIdentification;
        References = reqReferences;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationResponse message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_QZAf5uQXEeCGktPI9k4Dlw_29401960")]
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
    [IsoId("_QZAf5-QXEeCGktPI9k4Dlw_-804271867")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Linkages15 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Linkages15 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages15 References { get; init; } 
    #else
    public Linkages15 References { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the trade.
    /// </summary>
    [IsoId("_QZAf6OQXEeCGktPI9k4Dlw_-1145789065")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusAndReason10 Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatusAndReason10 Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusAndReason10 Status { get; init; } 
    #else
    public StatusAndReason10 Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_QZAf6eQXEeCGktPI9k4Dlw_1899696329")]
    [DisplayName("Clearing Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtls")]
    #endif
    [IsoXmlTag("ClrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Clearing3? ClearingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Clearing3? ClearingDetails { get; init; } 
    #else
    public Clearing3? ClearingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_QZKQ4OQXEeCGktPI9k4Dlw_-1695268832")]
    [DisplayName("Confirmation Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfPties")]
    #endif
    [IsoXmlTag("ConfPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationParties3? ConfirmationParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationParties3? ConfirmationParties { get; init; } 
    #else
    public ConfirmationParties3? ConfirmationParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_QZKQ4eQXEeCGktPI9k4Dlw_499478370")]
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


// Since SecuritiesTradeConfirmationResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationResponseV01.


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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.031.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// A SecuritiesSettlementConditionsModificationRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|A SecuritiesSettlementConditionsModificationRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
[IsoId("_19xJ4dBmEeihG9bKfarOOA")]
[DisplayName("Securities Settlement Condition Modification Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementConditionModificationStatusAdviceV08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.031.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmCondModStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.031.001.08";
    
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
    /// Constructs a SecuritiesSettlementConditionModificationStatusAdviceV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementConditionModificationStatusAdviceV08( Identification14 reqRequestReference,ProcessingStatus50Choice_ reqProcessingStatus )
    {
        RequestReference = reqRequestReference;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the SecuritiesSettlementConditionsModificationRequest.
    /// </summary>
    [IsoId("_19xJ49BmEeihG9bKfarOOA")]
    [DisplayName("Request Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRef")]
    #endif
    [IsoXmlTag("ReqRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Identification14 RequestReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Identification14 RequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification14 RequestReference { get; init; } 
    #else
    public Identification14 RequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_19xJ5dBmEeihG9bKfarOOA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification144? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification144? AccountOwner { get; init; } 
    #else
    public PartyIdentification144? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_19xJ59BmEeihG9bKfarOOA")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the request.
    /// </summary>
    [IsoId("_19xJ6dBmEeihG9bKfarOOA")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestDetails20? RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestDetails20? RequestDetails { get; init; } 
    #else
    public RequestDetails20? RequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_19xJ69BmEeihG9bKfarOOA")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingStatus50Choice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingStatus50Choice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus50Choice_ ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus50Choice_ ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_19xJ7dBmEeihG9bKfarOOA")]
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


// Since SecuritiesSettlementConditionModificationStatusAdviceV08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementConditionModificationStatusAdviceV08.


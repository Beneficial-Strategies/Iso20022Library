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
/// This record is an implementation of the sese.022.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesStatusOrStatementQueryStatusAdvice to an account owner to advise the status of a status query or statement query previously sent by the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends a SecuritiesStatusOrStatementQueryStatusAdvice to an account owner to advise the status of a status query or statement query previously sent by the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
[IsoId("_yoyk4SgSEeym1_Zp1BTvEw")]
[DisplayName("Securities Status Or Statement Query Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesStatusOrStatementQueryStatusAdviceV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.022.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesStsOrStmtQryStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.022.001.06";
    
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
    /// Constructs a SecuritiesStatusOrStatementQueryStatusAdviceV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesStatusOrStatementQueryStatusAdviceV06( DocumentIdentification54 reqQueryDetails,ProcessingStatus89Choice_ reqProcessingStatus )
    {
        QueryDetails = reqQueryDetails;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the query as per the account owner.
    /// </summary>
    [IsoId("_yoyk6SgSEeym1_Zp1BTvEw")]
    [DisplayName("Query Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryDtls")]
    #endif
    [IsoXmlTag("QryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification54 QueryDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification54 QueryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification54 QueryDetails { get; init; } 
    #else
    public DocumentIdentification54 QueryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_yoyk6ygSEeym1_Zp1BTvEw")]
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
    [IsoId("_yoyk7SgSEeym1_Zp1BTvEw")]
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
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_2EAcoyqFEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the request.
    /// </summary>
    [IsoId("_yoyk7ygSEeym1_Zp1BTvEw")]
    [DisplayName("Status Or Statement Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsOrStmtReqd")]
    #endif
    [IsoXmlTag("StsOrStmtReqd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusOrStatement11Choice_? StatusOrStatementRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusOrStatement11Choice_? StatusOrStatementRequested { get; init; } 
    #else
    public StatusOrStatement11Choice_? StatusOrStatementRequested { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_yoyk8SgSEeym1_Zp1BTvEw")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingStatus89Choice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingStatus89Choice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus89Choice_ ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus89Choice_ ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yoyk8ygSEeym1_Zp1BTvEw")]
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


// Since SecuritiesStatusOrStatementQueryStatusAdviceV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesStatusOrStatementQueryStatusAdviceV06.


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
/// This record is an implementation of the sese.042.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// |An account servicer sends a BuyInRegulatoryAdviceResponse to an account owner to advise the status of a buy-in report previously instructed by the account owner.
/// |The account servicer/owner relationship may be:|
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants|
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or|
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.||
/// 
/// Usage
/// |A BuyInRegulatpryReport may contain reports on multiple transactions. However, one BuyInRegulatoryReportStatusAdvice must be sent per transaction reported  unless the BuyInRegulatoryReport is rejected as a whole.||
/// The message may also be used to:|- re-send a message previously sent,
/// |- provide a third party with a copy of a message for information,|
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope||An account servicer sends a BuyInRegulatoryAdviceResponse to an account owner to advise the status of a buy-in report previously instructed by the account owner.||The account servicer/owner relationship may be:||- a central securities depository or another settlement market infrastructure acting on behalf of their participants||- an agent (sub-custodian) acting on behalf of their global custodian customer, or||- a custodian acting on behalf of an investment management institution or a broker/dealer.||||Usage||A BuyInRegulatpryReport may contain reports on multiple transactions. However, one BuyInRegulatoryReportStatusAdvice must be sent per transaction reported  unless the BuyInRegulatoryReport is rejected as a whole.|||The message may also be used to:|- re-send a message previously sent,||- provide a third party with a copy of a message for information,||- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
[IsoId("_DFqK8ZwYEeqtp-LOti013g")]
[DisplayName("Buy In Regulatory Advice Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyInRegulatoryAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.042.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRgltryAdvcRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.042.001.01";
    
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
    /// Constructs a BuyInRegulatoryAdviceResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyInRegulatoryAdviceResponseV01( Identification14 reqAdviceReference,ProcessingStatus79Choice_ reqProcessingStatus )
    {
        AdviceReference = reqAdviceReference;
        ProcessingStatus = reqProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the BuyInRegulatoryAdvice message for which the response is provided.
    /// </summary>
    [IsoId("_DFqK-ZwYEeqtp-LOti013g")]
    [DisplayName("Advice Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvcRef")]
    #endif
    [IsoXmlTag("AdvcRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Identification14 AdviceReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Identification14 AdviceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Identification14 AdviceReference { get; init; } 
    #else
    public Identification14 AdviceReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_DFqK-5wYEeqtp-LOti013g")]
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
    /// Account used in the original failing transaction.
    /// </summary>
    [IsoId("_DFqK_ZwYEeqtp-LOti013g")]
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
    /// Details of the buy-in.
    /// </summary>
    [IsoId("_4Pp1QZwYEeqtp-LOti013g")]
    [DisplayName("Buy In Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInAttrbts")]
    #endif
    [IsoXmlTag("BuyInAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BuyInAdviceDetails1? BuyInAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BuyInAdviceDetails1? BuyInAttributes { get; init; } 
    #else
    public BuyInAdviceDetails1? BuyInAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the processing status of the advice.
    /// </summary>
    [IsoId("_DFqLAZwYEeqtp-LOti013g")]
    [DisplayName("Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgSts")]
    #endif
    [IsoXmlTag("PrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingStatus79Choice_ ProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingStatus79Choice_ ProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus79Choice_ ProcessingStatus { get; init; } 
    #else
    public ProcessingStatus79Choice_ ProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DFqLA5wYEeqtp-LOti013g")]
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


// Since BuyInRegulatoryAdviceResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInRegulatoryAdviceResponseV01.


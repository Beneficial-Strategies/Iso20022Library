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
/// This record is an implementation of the seev.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to request the authorisation of an amendment of a previously sent Agent Corporate Action Election Advice message.
/// Usage
/// This message is used to request the amendment of a previously sent Agent Corporate Action Election Advice message.
/// Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.
/// This message is used when the terms and conditions of the corporate action event allow amendments.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to request the authorisation of an amendment of a previously sent Agent Corporate Action Election Advice message.|Usage|This message is used to request the amendment of a previously sent Agent Corporate Action Election Advice message.|Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.|This message is used when the terms and conditions of the corporate action event allow amendments.")]
[IsoId("_TNAo_tEwEd-BzquC8wXy7w_1507742806")]
[DisplayName("Agent CA Election Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAElectionAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.013.001.01";
    
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
    /// Constructs a AgentCAElectionAmendmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAElectionAmendmentRequestV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAElectionAdviceIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,SecuritiesAccount7 reqAccountDetails,CorporateActionElection1 reqOriginalElectionDetails,CorporateActionElection2 reqAmendedElectionDetails )
    {
        Identification = reqIdentification;
        AgentCAElectionAdviceIdentification = reqAgentCAElectionAdviceIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        OriginalElectionDetails = reqOriginalElectionDetails;
        AmendedElectionDetails = reqAmendedElectionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the request.
    /// </summary>
    [IsoId("_TNAo_9EwEd-BzquC8wXy7w_32107139")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Election Advice for which an amendment is requested.
    /// </summary>
    [IsoId("_TNApANEwEd-BzquC8wXy7w_61660705")]
    [DisplayName("Agent CA Election Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAElectionAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAElectionAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TNApAdEwEd-BzquC8wXy7w_-1916344559")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account.
    /// </summary>
    [IsoId("_TNJy4NEwEd-BzquC8wXy7w_-148394854")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount7 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount7 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount7 AccountDetails { get; init; } 
    #else
    public SecuritiesAccount7 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the original election to be amended.
    /// </summary>
    [IsoId("_TNJy4dEwEd-BzquC8wXy7w_915892144")]
    [DisplayName("Original Election Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlElctnDtls")]
    #endif
    [IsoXmlTag("OrgnlElctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionElection1 OriginalElectionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionElection1 OriginalElectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionElection1 OriginalElectionDetails { get; init; } 
    #else
    public CorporateActionElection1 OriginalElectionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the amendments to the election.
    /// </summary>
    [IsoId("_TNJy4tEwEd-BzquC8wXy7w_934364367")]
    [DisplayName("Amended Election Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmddElctnDtls")]
    #endif
    [IsoXmlTag("AmddElctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionElection2 AmendedElectionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionElection2 AmendedElectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionElection2 AmendedElectionDetails { get; init; } 
    #else
    public CorporateActionElection2 AmendedElectionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TNJy49EwEd-BzquC8wXy7w_459673267")]
    [DisplayName("Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctDtls")]
    #endif
    [IsoXmlTag("CtctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactPerson1? ContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactPerson1? ContactDetails { get; init; } 
    #else
    public ContactPerson1? ContactDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAElectionAmendmentRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionAmendmentRequestV01.


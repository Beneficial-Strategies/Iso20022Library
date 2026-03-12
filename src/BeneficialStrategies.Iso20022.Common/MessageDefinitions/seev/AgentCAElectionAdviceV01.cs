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



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to provide information about the clients&apos; election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.
/// Usage
/// This message can be used for a new election advice or an amended election advice.
/// If this message is used for a new election advice, the function of the message must be &apos;new election&apos;.
/// If this message is used for an amended election advice, the function of the message must be &apos;option change&apos; and the identification of the previously sent election advice must be present.
/// This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.
/// Note: this information can be also sent separately in the Agent Corporate Action Information advice message.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to provide information about the clients' election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.|Usage|This message can be used for a new election advice or an amended election advice.|If this message is used for a new election advice, the function of the message must be 'new election'.|If this message is used for an amended election advice, the function of the message must be 'option change' and the identification of the previously sent election advice must be present.|This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.|Note: this information can be also sent separately in the Agent Corporate Action Information advice message.")]
[IsoId("_TMtG-tEwEd-BzquC8wXy7w_1166385439")]
[DisplayName("Agent CA Election Advice V")]
public partial record AgentCAElectionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TMtG-9EwEd-BzquC8wXy7w_-42698000")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Provides information about the type of election advice and linked messages.
    /// </summary>
    [IsoId("_TM238NEwEd-BzquC8wXy7w_-1990867488")]
    [DisplayName("Election Advice Type And Linkage")]
    [IsoXmlTag("ElctnAdvcTpAndLkg")]
    public required ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TM238dEwEd-BzquC8wXy7w_1272192692")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Provides information about the election(s).
    /// </summary>
    [IsoId("_TM238tEwEd-BzquC8wXy7w_-1547276927")]
    [DisplayName("Election Details")]
    [IsoXmlTag("ElctnDtls")]
    public required CorporateActionElection3 ElectionDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information about the delivery details, beneficial owner details, etc.
    /// </summary>
    [IsoId("_TM2389EwEd-BzquC8wXy7w_-1731981881")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionAdditionalInformation1? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TM239NEwEd-BzquC8wXy7w_-741674043")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactPerson1? ContactDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCAElectionAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionAdviceV01.


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


namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.
/// Usage
/// This message should only be sent if additional information is required as part of the account maintenance process.
/// </summary>
[Description(@"Scope|The AccountAdditionalInformationRequest message is sent from a financial institution to an organisation as part of maintenance process. This message is sent in response to a request message from the organisation, if the business content is valid, but additional information is required.|Usage|This message should only be sent if additional information is required as part of the account maintenance process.")]
[IsoId("_mso-iNE9Ed-BzquC8wXy7w_-37995631")]
[DisplayName("Account Additional Information Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountAdditionalInformationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctAddtlInfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.012.001.01";
    
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
    /// Constructs a AccountAdditionalInformationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountAdditionalInformationRequestV01( References3 reqReferences,OrganisationIdentification6 reqOrganisationIdentification,BranchAndFinancialInstitutionIdentification4 reqAccountServicerIdentification,AccountForAction1 reqAccountIdentification )
    {
        References = reqReferences;
        OrganisationIdentification = reqOrganisationIdentification;
        AccountServicerIdentification = reqAccountServicerIdentification;
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_mso-idE9Ed-BzquC8wXy7w_1354481909")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References3 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References3 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References3 References { get; init; } 
    #else
    public References3 References { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier for an organisation.
    /// </summary>
    [IsoId("_msyIcNE9Ed-BzquC8wXy7w_844276535")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification6 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification6 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_msyIcdE9Ed-BzquC8wXy7w_-1890306852")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_msyIctE9Ed-BzquC8wXy7w_-672125053")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountForAction1 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountForAction1 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountForAction1 AccountIdentification { get; init; } 
    #else
    public AccountForAction1 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_msyIc9E9Ed-BzquC8wXy7w_-516297795")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature1? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature1? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AccountAdditionalInformationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountAdditionalInformationRequestV01.


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



namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required.
/// Usage
/// This message should only be sent if additional information is required as part of the account opening process.
/// </summary>
[Description(@"Scope|The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required.|Usage|This message should only be sent if additional information is required as part of the account opening process.")]
[IsoId("_s7Y_yNE9Ed-BzquC8wXy7w_1867153324")]
[DisplayName("Account Opening Additional Information Request V")]
public partial record AccountOpeningAdditionalInformationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngAddtlInfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.009.001.01";
    
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
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_s7Y_ydE9Ed-BzquC8wXy7w_1765185822")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References3 References { get; init; } 
    
    /// <summary>
    /// Identification of the organisation.
    /// </summary>
    [IsoId("_s7iwwNE9Ed-BzquC8wXy7w_-2055295141")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification6 OrganisationIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_s7iwwdE9Ed-BzquC8wXy7w_336169512")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount1 Account { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_s7iwwtE9Ed-BzquC8wXy7w_-911179757")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    
    /// <summary>
    /// Account contract established between the organisation or the Group to which the organisation belongs, and the account Servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_s7iww9E9Ed-BzquC8wXy7w_-792726722")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_s7iwxNE9Ed-BzquC8wXy7w_369890722")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountOpeningAdditionalInformationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningAdditionalInformationRequestV01.


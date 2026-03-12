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
/// This record is an implementation of the acmt.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This AccountExcludedMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account.
/// Usage
/// This update is about account details excluding any mandate information. The organisation will specify under the Account and Organisation tags the complete information as it should be in the financial institutions records after processing the update request.
/// </summary>
[Description(@"Scope|This AccountExcludedMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account.|Usage|This update is about account details excluding any mandate information. The organisation will specify under the Account and Organisation tags the complete information as it should be in the financial institutions records after processing the update request.")]
[IsoId("_pzkTNdE9Ed-BzquC8wXy7w_172692217")]
[DisplayName("Account Excluded Mandate Maintenance Request V")]
public partial record AccountExcludedMandateMaintenanceRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.015.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctExcldMndtMntncReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.015.001.01";
    
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
    [IsoId("_pzkTNtE9Ed-BzquC8wXy7w_232051449")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References4 References { get; init; } 
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_pzkTN9E9Ed-BzquC8wXy7w_891508527")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract2? ContractDates { get; init; } 
    
    /// <summary>
    /// Account contract established between the organisation or the Group to which the organisation belongs, and the account Servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_pzkTONE9Ed-BzquC8wXy7w_1405908737")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_pzkTOdE9Ed-BzquC8wXy7w_759774723")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount1 Account { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_pzuEMNE9Ed-BzquC8wXy7w_1509673772")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification4 AccountServicerIdentification { get; init; } 
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_pzuEMdE9Ed-BzquC8wXy7w_1958240607")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation6 Organisation { get; init; } 
    
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_pzuEMtE9Ed-BzquC8wXy7w_1402039717")]
    [DisplayName("Additional Message Information")]
    [IsoXmlTag("AddtlMsgInf")]
    public AdditionalInformation5? AdditionalMessageInformation { get; init; } 
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_pzuEM9E9Ed-BzquC8wXy7w_538629891")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature1? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountExcludedMandateMaintenanceRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountExcludedMandateMaintenanceRequestV01.


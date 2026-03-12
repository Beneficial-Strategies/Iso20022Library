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
/// This record is an implementation of the acmt.007.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.
/// </summary>
[Description(@"The AccountOpeningRequest message is sent from an organisation to a financial institution as part of the account opening process. It is the initial request message to open an account.")]
[IsoId("_1ENlzdcAEeq_l4BJLVUF2Q")]
[DisplayName("Account Opening Request V")]
public partial record AccountOpeningRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.007.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.007.001.04";
    
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
    [IsoId("_1ENl09cAEeq_l4BJLVUF2Q")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References4 References { get; init; } 
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_1ENl1dcAEeq_l4BJLVUF2Q")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification29? From { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_1ENl19cAEeq_l4BJLVUF2Q")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CustomerAccount4 Account { get; init; } 
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_1ENl2dcAEeq_l4BJLVUF2Q")]
    [DisplayName("Contract Dates")]
    [IsoXmlTag("CtrctDts")]
    public AccountContract2? ContractDates { get; init; } 
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_1ENl29cAEeq_l4BJLVUF2Q")]
    [DisplayName("Underlying Master Agreement")]
    [IsoXmlTag("UndrlygMstrAgrmt")]
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_1ENl3dcAEeq_l4BJLVUF2Q")]
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_1ENl39cAEeq_l4BJLVUF2Q")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public required Organisation33 Organisation { get; init; } 
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_1ENl4dcAEeq_l4BJLVUF2Q")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public OperationMandate4? Mandate { get; init; } 
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_1ENl49cAEeq_l4BJLVUF2Q")]
    [DisplayName("Group")]
    [IsoXmlTag("Grp")]
    public Group4? Group { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_1ENl5dcAEeq_l4BJLVUF2Q")]
    [DisplayName("Reference Account")]
    [IsoXmlTag("RefAcct")]
    public CashAccount40? ReferenceAccount { get; init; } 
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_1ENl59cAEeq_l4BJLVUF2Q")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature3? DigitalSignature { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1ENl6dcAEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountOpeningRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningRequestV04.


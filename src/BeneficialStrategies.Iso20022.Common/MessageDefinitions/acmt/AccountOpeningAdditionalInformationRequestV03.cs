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
/// This record is an implementation of the acmt.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required.
/// </summary>
[Description(@"The AccountOpeningAdditionalInformationRequest message is sent from a financial institution to an organisation as part of the account opening process. This message is sent in response to an opening request message from the organisation, if the business content is valid, but additional information is required.")]
[IsoId("_bfzgNW2PEei3KuUgpx7Xcw")]
[DisplayName("Account Opening Additional Information Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountOpeningAdditionalInformationRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.009.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctOpngAddtlInfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.009.001.03";
    
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
    /// Constructs a AccountOpeningAdditionalInformationRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountOpeningAdditionalInformationRequestV03( References3 reqReferences,OrganisationIdentification29 reqOrganisationIdentification,CustomerAccount4 reqAccount,BranchAndFinancialInstitutionIdentification6 reqAccountServicerIdentification )
    {
        References = reqReferences;
        OrganisationIdentification = reqOrganisationIdentification;
        Account = reqAccount;
        AccountServicerIdentification = reqAccountServicerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_bfzgN22PEei3KuUgpx7Xcw")]
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
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_bfzgOW2PEei3KuUgpx7Xcw")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification29? From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification29? From { get; init; } 
    #else
    public OrganisationIdentification29? From { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organisation.
    /// </summary>
    [IsoId("_bfzgO22PEei3KuUgpx7Xcw")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification29 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification29 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_bfzgPW2PEei3KuUgpx7Xcw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerAccount4 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustomerAccount4 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerAccount4 Account { get; init; } 
    #else
    public CustomerAccount4 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_bfzgP22PEei3KuUgpx7Xcw")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_bfzgQW2PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygMstrAgrmt")]
    #endif
    [IsoXmlTag("UndrlygMstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #else
    public ContractDocument1? UnderlyingMasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_bfzgQ22PEei3KuUgpx7Xcw")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature3? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature3? DigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bfzgRW2PEei3KuUgpx7Xcw")]
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


// Since AccountOpeningAdditionalInformationRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountOpeningAdditionalInformationRequestV03.


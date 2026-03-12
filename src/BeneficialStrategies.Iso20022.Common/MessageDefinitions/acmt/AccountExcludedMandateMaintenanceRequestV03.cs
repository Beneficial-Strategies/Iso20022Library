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
/// This record is an implementation of the acmt.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountExcludedMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account. Usage: this update is about account details excluding any mandate information.
/// If modification codes are not used: the organisation will specify under the “Account” and “Organisation” tags the complete information as it should be in the financial institution’s records after processing the update request. 
/// If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Account” and “Organisation” tags which elements must be added, deleted, modified, or if they are unchanged.
/// </summary>
[Description(@"The AccountExcludedMandateMaintenanceRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is the initial request message to update an account. Usage: this update is about account details excluding any mandate information.|If modification codes are not used: the organisation will specify under the “Account” and “Organisation” tags the complete information as it should be in the financial institution’s records after processing the update request. |If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Account” and “Organisation” tags which elements must be added, deleted, modified, or if they are unchanged.")]
[IsoId("_bfzgl22PEei3KuUgpx7Xcw")]
[DisplayName("Account Excluded Mandate Maintenance Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountExcludedMandateMaintenanceRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.015.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctExcldMndtMntncReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.015.001.03";
    
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
    /// Constructs a AccountExcludedMandateMaintenanceRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountExcludedMandateMaintenanceRequestV03( References4 reqReferences,CustomerAccountModification1 reqAccount,BranchAndFinancialInstitutionIdentification6 reqAccountServicerIdentification,OrganisationModification2 reqOrganisation )
    {
        References = reqReferences;
        Account = reqAccount;
        AccountServicerIdentification = reqAccountServicerIdentification;
        Organisation = reqOrganisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_bfzgmW2PEei3KuUgpx7Xcw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References4 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References4 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References4 References { get; init; } 
    #else
    public References4 References { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the business sender of the message, if it is not the account owner or account servicing financial institution.
    /// </summary>
    [IsoId("_bfzgm22PEei3KuUgpx7Xcw")]
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
    /// Specifies target dates.
    /// </summary>
    [IsoId("_bfzgnW2PEei3KuUgpx7Xcw")]
    [DisplayName("Contract Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDts")]
    #endif
    [IsoXmlTag("CtrctDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountContract2? ContractDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountContract2? ContractDates { get; init; } 
    #else
    public AccountContract2? ContractDates { get; set; } 
    #endif
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_bfzgn22PEei3KuUgpx7Xcw")]
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
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_bfzgoW2PEei3KuUgpx7Xcw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerAccountModification1 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustomerAccountModification1 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerAccountModification1 Account { get; init; } 
    #else
    public CustomerAccountModification1 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_bfzgo22PEei3KuUgpx7Xcw")]
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
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_bfzgpW2PEei3KuUgpx7Xcw")]
    [DisplayName("Organisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Org")]
    #endif
    [IsoXmlTag("Org")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationModification2 Organisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationModification2 Organisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationModification2 Organisation { get; init; } 
    #else
    public OrganisationModification2 Organisation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_bfzgp22PEei3KuUgpx7Xcw")]
    [DisplayName("Additional Message Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlMsgInf")]
    #endif
    [IsoXmlTag("AddtlMsgInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation5? AdditionalMessageInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation5? AdditionalMessageInformation { get; init; } 
    #else
    public AdditionalInformation5? AdditionalMessageInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_bfzgqW2PEei3KuUgpx7Xcw")]
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
    [IsoId("_bfzgq22PEei3KuUgpx7Xcw")]
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


// Since AccountExcludedMandateMaintenanceRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountExcludedMandateMaintenanceRequestV03.


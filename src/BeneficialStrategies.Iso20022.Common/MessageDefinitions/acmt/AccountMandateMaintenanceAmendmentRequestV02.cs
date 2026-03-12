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
/// This record is an implementation of the acmt.018.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. Usage: this update is only about mandate information. 
/// If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request. 
/// If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.
/// It is not possible to update the account characteristics or organisation information with this message.
/// 
/// </summary>
[Description(@"The AccountMandateMaintenanceAmendmentRequest message is sent from an organisation to a financial institution as part of the account maintenance process. It is sent in response to a request from the financial institution to send additional information. Usage: this update is only about mandate information. |If modification codes are not used: the organisation will specify under the “Mandate” and “Group” tags the complete information as it should be in the financial institution’s records after processing the update request. |If modification codes are used (in that case, they must be used everywhere): the organisation will specify under the “Mandate” and “Group” tags which elements must be added, deleted, modified, or if they are unchanged.|It is not possible to update the account characteristics or organisation information with this message.|")]
[IsoId("_XYvc8Q1TEeKGXqvMN6jpiw")]
[DisplayName("Account Mandate Maintenance Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountMandateMaintenanceAmendmentRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.018.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMndtMntncAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.018.001.02";
    
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
    /// Constructs a AccountMandateMaintenanceAmendmentRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountMandateMaintenanceAmendmentRequestV02( References4 reqReferences,AccountForAction1 reqAccountIdentification,BranchAndFinancialInstitutionIdentification5 reqAccountServicerIdentification,OrganisationIdentification8 reqOrganisationIdentification )
    {
        References = reqReferences;
        AccountIdentification = reqAccountIdentification;
        AccountServicerIdentification = reqAccountServicerIdentification;
        OrganisationIdentification = reqOrganisationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements for the identification of the message and related references.
    /// </summary>
    [IsoId("_XYvc8w1TEeKGXqvMN6jpiw")]
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
    [IsoId("_MiFqMA1YEeKGXqvMN6jpiw")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification8? From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification8? From { get; init; } 
    #else
    public OrganisationIdentification8? From { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies target dates.
    /// </summary>
    [IsoId("_XYvc9w1TEeKGXqvMN6jpiw")]
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
    [IsoId("_XYvc-w1TEeKGXqvMN6jpiw")]
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
    [IsoId("_XYvc_w1TEeKGXqvMN6jpiw")]
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
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme. |.
    /// </summary>
    [IsoId("_XYvdAw1TEeKGXqvMN6jpiw")]
    [DisplayName("Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrId")]
    #endif
    [IsoXmlTag("AcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 AccountServicerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organisation requesting the change.
    /// </summary>
    [IsoId("_XYvdBw1TEeKGXqvMN6jpiw")]
    [DisplayName("Organisation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgId")]
    #endif
    [IsoXmlTag("OrgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification8 OrganisationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification8 OrganisationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification8 OrganisationIdentification { get; init; } 
    #else
    public OrganisationIdentification8 OrganisationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_XYvdCw1TEeKGXqvMN6jpiw")]
    [DisplayName("Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mndt")]
    #endif
    [IsoXmlTag("Mndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OperationMandate3? Mandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OperationMandate3? Mandate { get; init; } 
    #else
    public OperationMandate3? Mandate { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_kvliMA4XEeKGXqvMN6jpiw")]
    [DisplayName("Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp")]
    #endif
    [IsoXmlTag("Grp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Group2? Group { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Group2? Group { get; init; } 
    #else
    public Group2? Group { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the signature with its components, namely signed info, signature value, key info and the object.
    /// </summary>
    [IsoId("_XYvdDw1TEeKGXqvMN6jpiw")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vUs-MA4AEeKGXqvMN6jpiw")]
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


// Since AccountMandateMaintenanceAmendmentRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountMandateMaintenanceAmendmentRequestV02.


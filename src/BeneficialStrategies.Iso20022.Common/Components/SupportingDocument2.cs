// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document supporting the contract registration.
/// </summary>
[IsoId("_6emK1248EeiU9cctagi5ow")]
[DisplayName("Supporting Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SupportingDocument2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SupportingDocument2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SupportingDocument2( System.String reqSupportingDocumentIdentification,DocumentIdentification28 reqCertificate,PartyIdentification135 reqAccountOwner,BranchAndFinancialInstitutionIdentification6 reqAccountServicer,ContractRegistrationReference1Choice_ reqContractReference )
    {
        SupportingDocumentIdentification = reqSupportingDocumentIdentification;
        Certificate = reqCertificate;
        AccountOwner = reqAccountOwner;
        AccountServicer = reqAccountServicer;
        ContractReference = reqContractReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document.
    /// </summary>
    [IsoId("_6oIhUW48EeiU9cctagi5ow")]
    [DisplayName("Supporting Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtgDocId")]
    #endif
    [IsoXmlTag("SpprtgDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SupportingDocumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SupportingDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SupportingDocumentIdentification { get; init; } 
    #else
    public System.String SupportingDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_6oIhU248EeiU9cctagi5ow")]
    [DisplayName("Original Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlReqId")]
    #endif
    [IsoXmlTag("OrgnlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalRequestIdentification { get; init; } 
    #else
    public System.String? OriginalRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the certificate for which the supporting document is provided.
    /// </summary>
    [IsoId("_6oIhVW48EeiU9cctagi5ow")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification28 Certificate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification28 Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28 Certificate { get; init; } 
    #else
    public DocumentIdentification28 Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_6oIhV248EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 AccountOwner { get; init; } 
    #else
    public PartyIdentification135 AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_6oIhWW48EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_6oIhW248EeiU9cctagi5ow")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentAmendment1? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentAmendment1? Amendment { get; init; } 
    #else
    public DocumentAmendment1? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the registered contract or the underlying contract for the supporting documents.
    /// </summary>
    [IsoId("_6oIhXW48EeiU9cctagi5ow")]
    [DisplayName("Contract Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctRef")]
    #endif
    [IsoXmlTag("CtrctRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContractRegistrationReference1Choice_ ContractReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContractRegistrationReference1Choice_ ContractReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractRegistrationReference1Choice_ ContractReference { get; init; } 
    #else
    public ContractRegistrationReference1Choice_ ContractReference { get; set; } 
    #endif
    
    /// <summary>
    /// Individual entry of the supporting document.
    /// </summary>
    [IsoId("_6oIhX248EeiU9cctagi5ow")]
    [DisplayName("Entry")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntry")]
    #endif
    [IsoXmlTag("Ntry")]
    public ValueList<SupportingDocumentEntry1> Entry { get; init; } = new ValueList<SupportingDocumentEntry1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6oIhX248EeiU9cctagi5ow
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6oIhYW48EeiU9cctagi5ow")]
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

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document supporting the contract registration.
/// </summary>
[IsoId("_6emK1248EeiU9cctagi5ow")]
[DisplayName("Supporting Document")]
public partial record SupportingDocument2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document.
    /// </summary>
    [IsoId("_6oIhUW48EeiU9cctagi5ow")]
    [DisplayName("Supporting Document Identification")]
    [IsoXmlTag("SpprtgDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SupportingDocumentIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_6oIhU248EeiU9cctagi5ow")]
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the certificate for which the supporting document is provided.
    /// </summary>
    [IsoId("_6oIhVW48EeiU9cctagi5ow")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public required DocumentIdentification28 Certificate { get; init; } 
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_6oIhV248EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification135 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_6oIhWW48EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; } 
    
    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_6oIhW248EeiU9cctagi5ow")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public DocumentAmendment1? Amendment { get; init; } 
    
    /// <summary>
    /// Reference of the registered contract or the underlying contract for the supporting documents.
    /// </summary>
    [IsoId("_6oIhXW48EeiU9cctagi5ow")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public required ContractRegistrationReference1Choice_ ContractReference { get; init; } 
    
    /// <summary>
    /// Individual entry of the supporting document.
    /// </summary>
    [IsoId("_6oIhX248EeiU9cctagi5ow")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<SupportingDocumentEntry1> Entry { get; init; } = new ValueList<SupportingDocumentEntry1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6oIhX248EeiU9cctagi5ow
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6oIhYW48EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}

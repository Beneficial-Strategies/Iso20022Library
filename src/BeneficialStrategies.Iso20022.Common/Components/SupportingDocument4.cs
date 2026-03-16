// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supporting Document4.
/// </summary>
[IsoId("_xR3ioTEyEe6g-ffJsqGiSA")]
[DisplayName("Supporting Document4")]
public partial record SupportingDocument4
{
    #nullable enable

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification272 AccountOwner { get; init; } 

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification8 AccountServicer { get; init; } 

    /// <summary>
    /// Amendment.
    /// </summary>
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public DocumentAmendment1? Amendment { get; init; } 

    /// <summary>
    /// Certificate.
    /// </summary>
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public required DocumentIdentification28 Certificate { get; init; } 

    /// <summary>
    /// Contract Reference.
    /// </summary>
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public required ContractRegistrationReference2Choice_ ContractReference { get; init; } 

    /// <summary>
    /// Entry.
    /// </summary>
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<SupportingDocumentEntry2> Entry { get; init; } = [];

    /// <summary>
    /// Original Request Identification.
    /// </summary>
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    public IsoMax35Text? OriginalRequestIdentification { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Supporting Document Identification.
    /// </summary>
    [DisplayName("Supporting Document Identification")]
    [IsoXmlTag("SpprtgDocId")]
    public required IsoMax35Text SupportingDocumentIdentification { get; init; } 

    
    #nullable disable
    
}

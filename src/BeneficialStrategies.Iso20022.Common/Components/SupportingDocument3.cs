// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control document supporting the contract registration.
/// </summary>
[IsoId("_jEXpgbGJEeuSTr8k0UEM8A")]
[DisplayName("Supporting Document")]
public record SupportingDocument3
{
    /// <summary>
    /// Unique and unambiguous identification of the supporting document.
    /// </summary>
    [IsoId("_jFVS0bGJEeuSTr8k0UEM8A")]
    [DisplayName("Supporting Document Identification")]
    [IsoXmlTag("SpprtgDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SupportingDocumentIdentification { get; init; }

    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_jFVS07GJEeuSTr8k0UEM8A")]
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalRequestIdentification { get; init; }

    /// <summary>
    /// Unique identification of the certificate for which the supporting document is provided.
    /// </summary>
    [IsoId("_jFVS1bGJEeuSTr8k0UEM8A")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public required DocumentIdentification28 Certificate { get; init; }

    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_jFVS17GJEeuSTr8k0UEM8A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification135 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_jFVS2bGJEeuSTr8k0UEM8A")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification6 AccountServicer { get; init; }

    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_jFVS27GJEeuSTr8k0UEM8A")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public DocumentAmendment1? Amendment { get; init; }

    /// <summary>
    /// Reference of the registered contract or the underlying contract for the supporting documents.
    /// </summary>
    [IsoId("_jFVS3bGJEeuSTr8k0UEM8A")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public required ContractRegistrationReference2Choice_ ContractReference { get; init; }

    /// <summary>
    /// Individual entry of the supporting document.
    /// </summary>
    [IsoId("_jFVS37GJEeuSTr8k0UEM8A")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<SupportingDocumentEntry2> Entry { get; init; } = [];

    // ID for the above is _jFVS37GJEeuSTr8k0UEM8A

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jFVS4bGJEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

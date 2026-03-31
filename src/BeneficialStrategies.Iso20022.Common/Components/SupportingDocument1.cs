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
[IsoId("_p3smQNLvEeSDLevdaFPXHw")]
[DisplayName("Supporting Document")]
public record SupportingDocument1
{
    /// <summary>
    /// Unique and unambiguous identification of the supporting document.
    /// </summary>
    [IsoId("_Z6tzQNM-EeSDLevdaFPXHw")]
    [DisplayName("Supporting Document Identification")]
    [IsoXmlTag("SpprtgDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SupportingDocumentIdentification { get; init; }

    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_jO8wodLvEeSDLevdaFPXHw")]
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalRequestIdentification { get; init; }

    /// <summary>
    /// Unique identification of the certificate for which the supporting document is provided.
    /// </summary>
    [IsoId("_ht2YYNM-EeSDLevdaFPXHw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public required DocumentIdentification28 Certificate { get; init; }

    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_kiKTENM-EeSDLevdaFPXHw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification77 AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_nontsNM-EeSDLevdaFPXHw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required BranchAndFinancialInstitutionIdentification5 AccountServicer { get; init; }

    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_AOWtUNM_EeSDLevdaFPXHw")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public DocumentAmendment1? Amendment { get; init; }

    /// <summary>
    /// Reference of the registered contract or the underlying contract for the supporting documents.
    /// </summary>
    [IsoId("_tPnLYNM-EeSDLevdaFPXHw")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    public required ContractRegistrationReference1Choice_ ContractReference { get; init; }

    /// <summary>
    /// Individual entry of the supporting document.
    /// </summary>
    [IsoId("_Jx0AkNM_EeSDLevdaFPXHw")]
    [DisplayName("Entry")]
    [IsoXmlTag("Ntry")]
    public ValueList<SupportingDocumentEntry1> Entry { get; init; } = [];

    // ID for the above is _Jx0AkNM_EeSDLevdaFPXHw

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_4p0uQQtMEeWkxvNyFrBT8Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

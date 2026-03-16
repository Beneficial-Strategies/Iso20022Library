// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate against which all currency control transactions are registered.
/// </summary>
[IsoId("_UkaEYXh1EeidzqjNEfehPg")]
[DisplayName("Transaction Certificate")]
public record TransactionCertificate3
{
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_UyotoXh1EeidzqjNEfehPg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Reference of the transaction certificate.
    /// </summary>
    [IsoId("_Uyoto3h1EeidzqjNEfehPg")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public required DocumentIdentification28 Certificate { get; init; }

    /// <summary>
    /// Cash account, linked to the registered contract, on which the cash entry is made.
    /// </summary>
    [IsoId("_UyotpXh1EeidzqjNEfehPg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount38? Account { get; init; }

    /// <summary>
    /// Country in which the bank account is located, when the bank which services the account is located in another country.
    /// </summary>
    [IsoId("_Uyotp3h1EeidzqjNEfehPg")]
    [DisplayName("Bank Account Domiciliation Country")]
    [IsoXmlTag("BkAcctDmcltnCtry")]
    public CountryCode? BankAccountDomiciliationCountry { get; init; }

    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_UyotqXh1EeidzqjNEfehPg")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public DocumentAmendment1? Amendment { get; init; }

    /// <summary>
    /// Record of the transaction certificate.
    /// </summary>
    [IsoId("_Uyotq3h1EeidzqjNEfehPg")]
    [DisplayName("Certificate Record")]
    [IsoXmlTag("CertRcrd")]
    public ValueList<TransactionCertificateRecord1> CertificateRecord { get; init; } = [];

    // ID for the above is _Uyotq3h1EeidzqjNEfehPg

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UyotrXh1EeidzqjNEfehPg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

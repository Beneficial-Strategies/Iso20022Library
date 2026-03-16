// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate record in which all currency control transactions are registered.
/// </summary>
[IsoId("_LUhDsNLiEeSdq5yU2aaSNw")]
[DisplayName("Transaction Certificate Record")]
public record TransactionCertificateRecord1
{
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    [IsoId("_RPZRQNLjEeSdq5yU2aaSNw")]
    [DisplayName("Certificate Record Identification")]
    [IsoXmlTag("CertRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CertificateRecordIdentification { get; init; }

    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    [IsoId("_aSH2ANLjEeSdq5yU2aaSNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionCertificate2 Transaction { get; init; }

    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    [IsoId("_KGGd4tLkEeSDLevdaFPXHw")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public TransactionCertificateContract1? Contract { get; init; }

    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    [IsoId("_HyBtYTm5EeWDb47rJ6ki4Q")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation3> Attachment { get; init; } = [];
}

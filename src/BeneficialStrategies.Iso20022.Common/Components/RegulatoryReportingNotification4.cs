// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regulatory Reporting Notification4.
/// </summary>
[IsoId("_5zPGwTEyEe6g-ffJsqGiSA")]
[DisplayName("Regulatory Reporting Notification4")]
public record RegulatoryReportingNotification4
{
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
    /// Transaction Certificate.
    /// </summary>
    [DisplayName("Transaction Certificate")]
    [IsoXmlTag("TxCert")]
    public ValueList<TransactionCertificate4> TransactionCertificate { get; init; } = [];

    /// <summary>
    /// Transaction Notification Identification.
    /// </summary>
    [DisplayName("Transaction Notification Identification")]
    [IsoXmlTag("TxNtfctnId")]
    public required IsoMax35Text TransactionNotificationIdentification { get; init; }
}

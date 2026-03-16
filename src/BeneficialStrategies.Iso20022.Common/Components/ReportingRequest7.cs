// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting Request7.
/// </summary>
[IsoId("_7GI5ETEyEe6g-ffJsqGiSA")]
[DisplayName("Reporting Request7")]
public record ReportingRequest7
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required Party50Choice_ AccountOwner { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Reporting Period.
    /// </summary>
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public ReportingPeriod5? ReportingPeriod { get; init; }

    /// <summary>
    /// Reporting Sequence.
    /// </summary>
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; }

    /// <summary>
    /// Requested Balance Type.
    /// </summary>
    [DisplayName("Requested Balance Type")]
    [IsoXmlTag("ReqdBalTp")]
    public ValueList<BalanceType13> RequestedBalanceType { get; init; } = [];

    /// <summary>
    /// Requested Message Name Identification.
    /// </summary>
    [DisplayName("Requested Message Name Identification")]
    [IsoXmlTag("ReqdMsgNmId")]
    public required IsoMax35Text RequestedMessageNameIdentification { get; init; }

    /// <summary>
    /// Requested Transaction Type.
    /// </summary>
    [DisplayName("Requested Transaction Type")]
    [IsoXmlTag("ReqdTxTp")]
    public TransactionType2? RequestedTransactionType { get; init; }
}

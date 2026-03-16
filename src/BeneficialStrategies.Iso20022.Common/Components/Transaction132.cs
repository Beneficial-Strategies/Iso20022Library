// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry transaction
/// </summary>
[IsoId("_nNkNAYv5EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
public record Transaction132
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_nTf14Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_nTf144v5EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_wU8JIbXmEeusf7oR9YukCg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public AdditionalService2? AdditionalService { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_nTf15Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_nTf154v5EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification18 TransactionIdentification { get; init; }

    /// <summary>
    /// Amount used for reconciliation.
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field
    /// </summary>
    [IsoId("_nTf16Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_nTf164v5EeumSPwlS1PkxQ")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public AdditionalAmounts3? AdditionalAmount { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_nTgc8Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; }

    /// <summary>
    /// Balance of an account.
    /// </summary>
    [IsoId("_nTgc84v5EeumSPwlS1PkxQ")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public AccountBalance2? AccountBalance { get; init; }

    /// <summary>
    /// Account information of a statement of account.
    /// </summary>
    [IsoId("_nTgc9Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Account Statement Data")]
    [IsoXmlTag("AcctStmtData")]
    public AccountStatementData2? AccountStatementData { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_nTgc94v5EeumSPwlS1PkxQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails3? AccountFrom { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_nTgc-Yv5EeumSPwlS1PkxQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_nTgc-4v5EeumSPwlS1PkxQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}

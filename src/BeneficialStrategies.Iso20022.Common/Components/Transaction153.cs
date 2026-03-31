// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_qoo10YdQEeuBS50MFjViNw")]
[DisplayName("Transaction")]
public record Transaction153
{
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see &quot;Transaction type codes&quot; in ISO 8583 &quot;Financial transaction card originated messages — Interchange message specifications&quot;
    /// </summary>
    [IsoId("_qtoDgYdQEeuBS50MFjViNw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ISO8583TransactionTypeCode TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_qtoDg4dQEeuBS50MFjViNw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    [IsoId("_u2eHYbXjEeusf7oR9YukCg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public ValueList<AdditionalService2> AdditionalService { get; init; } = [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_qtoDhYdQEeuBS50MFjViNw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification51 TransactionIdentification { get; init; }

    /// <summary>
    /// Amount used for reconciliation.
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field.
    /// </summary>
    [IsoId("_qtoDh4dQEeuBS50MFjViNw")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public Amount15? ReconciliationAmount { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    [IsoId("_qtoDiYdQEeuBS50MFjViNw")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<AdditionalAmounts3> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_qtoDi4dQEeuBS50MFjViNw")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_qtoDjYdQEeuBS50MFjViNw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}

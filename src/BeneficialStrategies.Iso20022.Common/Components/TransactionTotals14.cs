// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Totals14.
/// </summary>
[IsoId("_-yMVUY1OEe6S0_1AaJzQCA")]
[DisplayName("Transaction Totals14")]
public partial record TransactionTotals14
{
    #nullable enable

    /// <summary>
    /// Additional Fee Reconciliation.
    /// </summary>
    [DisplayName("Additional Fee Reconciliation")]
    [IsoXmlTag("AddtlFeeRcncltn")]
    public ValueList<AdditionalFeeReconciliation3> AdditionalFeeReconciliation { get; init; } = [];

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Checkpoint Reference.
    /// </summary>
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    public IsoMax35Text? CheckpointReference { get; init; } 

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required IsoMin2Max3NumericText Currency { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Financial.
    /// </summary>
    [DisplayName("Financial")]
    [IsoXmlTag("Fin")]
    public ValueList<FinancialReconciliation3> Financial { get; init; } = [];

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; } 

    /// <summary>
    /// Message.
    /// </summary>
    [DisplayName("Message")]
    [IsoXmlTag("Msg")]
    public ValueList<MessageReconciliation3> Message { get; init; } = [];

    
    #nullable disable
    
}

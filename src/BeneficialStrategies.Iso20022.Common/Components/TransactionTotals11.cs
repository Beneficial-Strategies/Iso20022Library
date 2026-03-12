// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Totals of the reconciliation.
/// </summary>
[IsoId("_mVydMVANEeedyPuM0kK2EQ")]
[DisplayName("Transaction Totals")]
public partial record TransactionTotals11
{
    #nullable enable
    
    /// <summary>
    /// Date and identification of reconciliation.
    /// </summary>
    [IsoId("_C-XcQcyfEeiqqJhU2tqK8A")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; } 
    
    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_mhPfQVANEeedyPuM0kK2EQ")]
    [DisplayName("Financial Reconciliation")]
    [IsoXmlTag("FinRcncltn")]
    public FinancialReconcillation1? FinancialReconciliation { get; init; } 
    
    /// <summary>
    /// Contains total message count.
    /// </summary>
    [IsoId("_mhPfQ1ANEeedyPuM0kK2EQ")]
    [DisplayName("Message Reconciliation")]
    [IsoXmlTag("MsgRcncltn")]
    public MessageReconcillation1? MessageReconciliation { get; init; } 
    
    /// <summary>
    /// Contains additional fee reconciliation data.
    /// </summary>
    [IsoId("_mhPfRVANEeedyPuM0kK2EQ")]
    [DisplayName("Additional Fee Reconciliation")]
    [IsoXmlTag("AddtlFeeRcncltn")]
    public AdditionalFeeReconciliation1? AdditionalFeeReconciliation { get; init; } 
    
    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_y34jEcytEeiqqJhU2tqK8A")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public required IsoMin2Max3NumericText Currency { get; init; } 
    
    /// <summary>
    /// Net amount of reconciliation.
    /// ISO 8583:87/93 bit 97
    /// </summary>
    [IsoId("_ixQ6Uc5ZEeiEmaZryQQ14Q")]
    [DisplayName("Net Amount Reconciliation")]
    [IsoXmlTag("NetAmtRcncltn")]
    public Amount5? NetAmountReconciliation { get; init; } 
    
    
    #nullable disable
    
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction for whose batch capture has been rejected.
/// </summary>
[IsoId("_lXK0QQx5Eeqdx6buGpCCQw")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet25
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_liRRAAx5Eeqdx6buGpCCQw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    
    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_liRRAgx5Eeqdx6buGpCCQw")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType10 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_liRRBAx5Eeqdx6buGpCCQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; } 
    
    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_liRRBgx5Eeqdx6buGpCCQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; } 
    
    
    #nullable disable
    
}

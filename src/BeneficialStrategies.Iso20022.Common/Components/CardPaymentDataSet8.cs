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
[IsoId("_W8SbMTSgEeOnFuyVSIQZKg")]
[DisplayName("Card Payment Data Set")]
public partial record CardPaymentDataSet8
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_XLnQoTSgEeOnFuyVSIQZKg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    
    /// <summary>
    /// Response to the capture of the transaction.
    /// </summary>
    [IsoId("_XLnQozSgEeOnFuyVSIQZKg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType1 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Data related to the environment of the transaction.
    /// </summary>
    [IsoId("_XLnQpTSgEeOnFuyVSIQZKg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment21 Environment { get; init; } 
    
    /// <summary>
    /// Transaction that has been rejected.
    /// </summary>
    [IsoId("_XLnQpzSgEeOnFuyVSIQZKg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransactionAdviceResponse5 Transaction { get; init; } 
    
    
    #nullable disable
    
}

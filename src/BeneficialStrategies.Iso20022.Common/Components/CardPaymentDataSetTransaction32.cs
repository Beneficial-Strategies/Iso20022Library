// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction to be authorised in a batch.
/// </summary>
[IsoId("_eECS8Qx7Eeqdx6buGpCCQw")]
[DisplayName("Card Payment Data Set Transaction")]
public partial record CardPaymentDataSetTransaction32
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_ePLL8Qx7Eeqdx6buGpCCQw")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_ePLL8wx7Eeqdx6buGpCCQw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; } 
    
    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_ePLL9Qx7Eeqdx6buGpCCQw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment74 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_ePLL9wx7Eeqdx6buGpCCQw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext28? Context { get; init; } 
    
    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_ePLL-Qx7Eeqdx6buGpCCQw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction92 Transaction { get; init; } 
    
    
    #nullable disable
    
}

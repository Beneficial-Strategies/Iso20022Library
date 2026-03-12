// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall process covering the trade and settlement transactions of financial instruments.
/// </summary>
[IsoId("_celg8UGZEeWqy4niLuXETA")]
[DisplayName("Settlement Type And Identification")]
public partial record SettlementTypeAndIdentification20
{
    #nullable enable
    
    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_csbIo0GZEeWqy4niLuXETA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; } 
    
    /// <summary>
    /// Reference of the transaction.
    /// </summary>
    [IsoId("_csbIq0GZEeWqy4niLuXETA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the intended settlement date.
    /// </summary>
    [IsoId("_csbIrUGZEeWqy4niLuXETA")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public DateAndDateTimeChoice_? SettlementDate { get; init; } 
    
    
    #nullable disable
    
}

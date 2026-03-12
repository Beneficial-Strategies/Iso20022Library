// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment funds transfer instructions from intraday queue.
/// </summary>
[IsoId("_kEa_wBt4Eeaiht5D4a9WSA")]
[DisplayName("Queued Transactions Report")]
public partial record QueuedTransactionsReport1
{
    #nullable enable
    
    /// <summary>
    /// List of queue names/ identifiers.
    /// </summary>
    [IsoId("_MmxNEBt5Eeaiht5D4a9WSA")]
    [DisplayName("Queue Type")]
    [IsoXmlTag("QTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text QueueType { get; init; } 
    
    /// <summary>
    /// Number of transactions in the queue.
    /// </summary>
    [IsoId("_TYJ58Bt8Eeaiht5D4a9WSA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Total amount of transactions in a given queue.
    /// </summary>
    [IsoId("_draScBt8Eeaiht5D4a9WSA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ActiveCurrencyAndAmount TotalAmount { get; init; } 
    
    /// <summary>
    /// Transaction details sorted by counterparty account.
    /// </summary>
    [IsoId("_JMwngBt9Eeaiht5D4a9WSA")]
    [DisplayName("Breakdown By Counterparty")]
    [IsoXmlTag("BrkdwnByCtrPty")]
    public QueueTransaction1? BreakdownByCounterparty { get; init; } 
    
    
    #nullable disable
    
}

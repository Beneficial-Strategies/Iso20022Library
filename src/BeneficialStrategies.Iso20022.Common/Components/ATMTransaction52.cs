// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction52.
/// </summary>
[IsoId("_kDRiAaE3Ee-MRKYsaX6JDg")]
[DisplayName("ATM Transaction52")]
public partial record ATMTransaction52
{
    #nullable enable

    /// <summary>
    /// ATM Totals.
    /// </summary>
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ValueList<ATMTotals4> ATMTotals { get; init; } = [];

    /// <summary>
    /// Cassette.
    /// </summary>
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette3> Cassette { get; init; } = [];

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public required IsoMax35Text ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; } 

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType12 TransactionResponse { get; init; } 

    /// <summary>
    /// Type Of Operation.
    /// </summary>
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation2Code? TypeOfOperation { get; init; } 

    
    #nullable disable
    
}

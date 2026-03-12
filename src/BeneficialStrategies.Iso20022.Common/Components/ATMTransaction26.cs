// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the reconciliation response.
/// </summary>
[IsoId("_iiJCga48EeWRfYPBaeOY8w")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction26
{
    #nullable enable
    
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_iskw4a48EeWRfYPBaeOY8w")]
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation1Code? TypeOfOperation { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_iskw4648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_iskw5a48EeWRfYPBaeOY8w")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Result of the reconciliation.
    /// </summary>
    [IsoId("_iskw5648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType7 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_uEGp0K48EeWRfYPBaeOY8w")]
    [DisplayName("ATM Totals")]
    [IsoXmlTag("ATMTtls")]
    public ATMTotals1? ATMTotals { get; init; } 
    
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_36_PYK48EeWRfYPBaeOY8w")]
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ATMCassette2? Cassette { get; init; } 
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_iskw6a48EeWRfYPBaeOY8w")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand7? Command { get; init; } 
    
    
    #nullable disable
    
}

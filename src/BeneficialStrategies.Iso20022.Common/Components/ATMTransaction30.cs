// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction30.
/// </summary>
[IsoId("_yy25YJ2pEe-4seDr3Li2Ew")]
[DisplayName("ATM Transaction30")]
public partial record ATMTransaction30
{
    #nullable enable

    /// <summary>
    /// Cassette.
    /// </summary>
    [DisplayName("Cassette")]
    [IsoXmlTag("Csstt")]
    public ValueList<ATMCassette3> Cassette { get; init; } = [];

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifier3? TransactionIdentification { get; init; } 

    /// <summary>
    /// Type Of Operation.
    /// </summary>
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public required ATMOperation2Code TypeOfOperation { get; init; } 

    
    #nullable disable
    
}

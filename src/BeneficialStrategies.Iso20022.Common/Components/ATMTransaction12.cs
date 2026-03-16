// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the reconciliation response.
/// </summary>
[IsoId("_NBXnUYt2EeSLQutgI1Ulfw")]
[DisplayName("ATM Transaction")]
public record ATMTransaction12
{
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_M_NnwCrCEeWRf8RNsvC5fQ")]
    [DisplayName("Type Of Operation")]
    [IsoXmlTag("TpOfOpr")]
    public ATMOperation1Code? TypeOfOperation { get; init; }

    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_h0fNgCrCEeWRf8RNsvC5fQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_NNcUc4t2EeSLQutgI1Ulfw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; }

    /// <summary>
    /// Result of the reconciliation.
    /// </summary>
    [IsoId("_NNcUd4t2EeSLQutgI1Ulfw")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType3 TransactionResponse { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_NNcUfYt2EeSLQutgI1Ulfw")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; }
}

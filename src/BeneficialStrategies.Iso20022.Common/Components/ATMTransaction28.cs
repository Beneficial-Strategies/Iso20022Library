// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement of the exception advice.
/// </summary>
[IsoId("_KMtHsa5HEeWCgYcWSNgX5g")]
[DisplayName("ATM Transaction")]
public record ATMTransaction28
{
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_KZEvwa5HEeWCgYcWSNgX5g")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifier1? TransactionIdentification { get; init; }

    /// <summary>
    /// Response to the advice.
    /// </summary>
    [IsoId("_KZEvx65HEeWCgYcWSNgX5g")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_KZEvza5HEeWCgYcWSNgX5g")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];
}

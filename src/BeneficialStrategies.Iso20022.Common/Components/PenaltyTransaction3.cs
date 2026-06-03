// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the transaction for which the penalties apply.
/// </summary>
[IsoId("_xXR-w6gzEfCXwLUUylXgrQ")]
[DisplayName("Penalty Transaction3")]
public record PenaltyTransaction3
{
    /// <summary>
    /// Reference of the transaction for which penalties are provided.
    /// </summary>
    [IsoId("_xaE0AagzEfCXwLUUylXgrQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required TransactionIdentifications55 Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_xaE0A6gzEfCXwLUUylXgrQ")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification136? ReferenceOwner { get; init; }

    /// <summary>
    /// Further details on the transaction for which the penalties apply.
    /// </summary>
    [IsoId("_xaE0BagzEfCXwLUUylXgrQ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public PenaltyTransactionRecord2? TransactionDetails { get; init; }

    /// <summary>
    /// Net settlement movement details for which the penalties apply.
    /// </summary>
    [IsoId("_xaE0B6gzEfCXwLUUylXgrQ")]
    [DisplayName("Net Movement Details")]
    [IsoXmlTag("NetMvmntDtls")]
    public PenaltyNetMovementRecord1? NetMovementDetails { get; init; }
}

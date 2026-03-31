// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further means of referencing a payment transaction.
/// </summary>
[IsoId("_rf468HrhEeidVZmeoasaWQ")]
[DisplayName("Payment Identification")]
public record PaymentIdentification8
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_r0WIAXrhEeidVZmeoasaWQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.
    /// </summary>
    [IsoId("_r0WIA3rhEeidVZmeoasaWQ")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_vLfqAXrhEeidVZmeoasaWQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_r0WIBXrhEeidVZmeoasaWQ")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? UETR { get; init; }
}

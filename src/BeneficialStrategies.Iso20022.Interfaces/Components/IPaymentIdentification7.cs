// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further means of referencing a payment transaction.
/// </summary>
[IsoId("_Tyw-UXrhEeidVZmeoasaWQ")]
public interface IPaymentIdentification7 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_UFMyIXrhEeidVZmeoasaWQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    Max35Text? InstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_UFMyI3rhEeidVZmeoasaWQ")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    Max35Text EndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_UFMyJXrhEeidVZmeoasaWQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    Max35Text? TransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_ymm7cXrgEeidVZmeoasaWQ")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    UUIDv4Identifier? UETR { get; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_UFMyJ3rhEeidVZmeoasaWQ")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    Max35Text? ClearingSystemReference { get; }
}

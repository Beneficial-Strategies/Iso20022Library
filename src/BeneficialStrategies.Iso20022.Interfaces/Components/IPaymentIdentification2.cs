// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further means of referencing a payment transaction.
/// </summary>
[IsoId("_Ps9tQdp-Ed-ak6NoX_4Aeg_1593827907")]
public interface IPaymentIdentification2 : IIsoComponent
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction.||Usage: the instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_Ps9tQtp-Ed-ak6NoX_4Aeg_1593828020")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    IsoMax35Text? InstructionIdentification { get; }

    /// <summary>
    /// Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.
    /// Usage: In case there are technical limitations to carry on multiple references, the end-to-end identification must be carried on throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_Ps9tQ9p-Ed-ak6NoX_4Aeg_1593827967")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    IsoMax35Text EndToEndIdentification { get; }

    /// <summary>
    /// Unique identification assigned by the first instructing agent to unambiguously identify the transaction and passed on, unchanged, throughout the entire interbank chain. ||Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure the transaction identification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_Ps9tRNp-Ed-ak6NoX_4Aeg_1735127457")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    IsoMax35Text TransactionIdentification { get; }
}

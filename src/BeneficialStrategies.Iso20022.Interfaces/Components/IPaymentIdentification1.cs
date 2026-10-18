// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further means of referencing a payment transaction.
/// </summary>
[IsoId("_Prnpd9p-Ed-ak6NoX_4Aeg_1924360852")]
public interface IPaymentIdentification1 : IIsoComponent
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_PrnpeNp-Ed-ak6NoX_4Aeg_1924360930")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    IsoMax35Text? InstructionIdentification { get; }

    /// <summary>
    /// Unique identification assigned by the initiating party to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.
    /// </summary>
    [IsoId("_Prnpedp-Ed-ak6NoX_4Aeg_1924360895")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    IsoMax35Text EndToEndIdentification { get; }
}

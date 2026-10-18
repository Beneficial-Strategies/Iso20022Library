// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further details the information related to the type of payment.
/// </summary>
[IsoId("_TGhDCtp-Ed-ak6NoX_4Aeg_-579871579")]
public interface IPaymentTypeInformation6 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_TGq0ANp-Ed-ak6NoX_4Aeg_-579871562")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_TGq0Adp-Ed-ak6NoX_4Aeg_-579871448")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IServiceLevel2Choice? ServiceLevel { get; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_TGq0Atp-Ed-ak6NoX_4Aeg_-579871544")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    ClearingChannel2Code? ClearingChannel { get; }

    /// <summary>
    /// User community specific instrument.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    [IsoId("_TGq0A9p-Ed-ak6NoX_4Aeg_-579871189")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    ILocalInstrument1Choice? LocalInstrument { get; }

    /// <summary>
    /// Identifies the direct debit sequence, eg, first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_TGq0BNp-Ed-ak6NoX_4Aeg_1750627501")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    SequenceType1Code? SequenceType { get; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_TGq0Bdp-Ed-ak6NoX_4Aeg_-579871509")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    PaymentCategoryPurpose1Code? CategoryPurpose { get; }
}

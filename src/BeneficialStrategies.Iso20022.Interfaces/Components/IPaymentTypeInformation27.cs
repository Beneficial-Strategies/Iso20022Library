// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the type of payment.
/// </summary>
[IsoId("_caAocXR0EeiH1ZOt2UD8vQ")]
public interface IPaymentTypeInformation27 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_clCMs3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_clCMtXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    ClearingChannel2Code? ClearingChannel { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_clCMt3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IEnumerable<IServiceLevel8Choice> ServiceLevel { get; }

    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_clCMuXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    ILocalInstrument2Choice? LocalInstrument { get; }

    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_clCMu3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    SequenceType3Code? SequenceType { get; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_clCMvXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    ICategoryPurpose1Choice? CategoryPurpose { get; }
}

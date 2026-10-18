// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details of the type of payment.
/// </summary>
[IsoId("_t5DC4VkyEeGeoaLUQk__nA_2129090901")]
public interface IPaymentTypeInformation24 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_t5DC4lkyEeGeoaLUQk__nA_-909737385")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_t5DC41kyEeGeoaLUQk__nA_-440929970")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IServiceLevel8Choice? ServiceLevel { get; }

    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_t5DC5FkyEeGeoaLUQk__nA_1373205512")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    ILocalInstrument2Choice? LocalInstrument { get; }

    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_t5Mz4FkyEeGeoaLUQk__nA_593158191")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    SequenceType3Code? SequenceType { get; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_t5Mz4VkyEeGeoaLUQk__nA_-16576208")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    ICategoryPurpose1Choice? CategoryPurpose { get; }
}

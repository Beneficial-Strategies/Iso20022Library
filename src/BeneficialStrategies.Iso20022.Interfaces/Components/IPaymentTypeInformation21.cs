// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details of the type of payment.
/// </summary>
[IsoId("_THQp4Np-Ed-ak6NoX_4Aeg_40856737")]
public interface IPaymentTypeInformation21 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_THQp4dp-Ed-ak6NoX_4Aeg_40856798")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_THQp4tp-Ed-ak6NoX_4Aeg_40856859")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    ClearingChannel2Code? ClearingChannel { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_THQp49p-Ed-ak6NoX_4Aeg_40857383")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IServiceLevel8Choice? ServiceLevel { get; }

    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_THQp5Np-Ed-ak6NoX_4Aeg_40857292")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    ILocalInstrument2Choice? LocalInstrument { get; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_THQp5dp-Ed-ak6NoX_4Aeg_277971084")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    ICategoryPurpose1Choice? CategoryPurpose { get; }
}

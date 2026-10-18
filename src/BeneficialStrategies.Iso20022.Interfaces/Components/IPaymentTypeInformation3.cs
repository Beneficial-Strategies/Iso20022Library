// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further details the information related to the type of payment.
/// </summary>
[IsoId("_TGOIE9p-Ed-ak6NoX_4Aeg_926240939")]
public interface IPaymentTypeInformation3 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_TGOIFNp-Ed-ak6NoX_4Aeg_1174666100")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_TGOIFdp-Ed-ak6NoX_4Aeg_1288260951")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IServiceLevel2Choice? ServiceLevel { get; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_TGOIFtp-Ed-ak6NoX_4Aeg_2008409724")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    ClearingChannel2Code? ClearingChannel { get; }

    /// <summary>
    /// User community specific instrument.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    [IsoId("_TGOIF9p-Ed-ak6NoX_4Aeg_-1900524089")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    ILocalInstrument1Choice? LocalInstrument { get; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_TGOIGNp-Ed-ak6NoX_4Aeg_2008410121")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    PaymentCategoryPurpose1Code? CategoryPurpose { get; }
}

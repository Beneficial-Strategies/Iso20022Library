// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further details the information related to the type of payment.
/// </summary>
[IsoId("_TF7NJdp-Ed-ak6NoX_4Aeg_622781299")]
public interface IPaymentTypeInformation5 : IIsoComponent
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_TF7NJtp-Ed-ak6NoX_4Aeg_622781702")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority2Code? InstructionPriority { get; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_TF7NJ9p-Ed-ak6NoX_4Aeg_622781762")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    IRestrictedProprietaryChoice? ServiceLevel { get; }

    /// <summary>
    /// Specifies the clearing channel to be used for the instruction.
    /// </summary>
    [IsoId("_TGEXENp-Ed-ak6NoX_4Aeg_-1369500381")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    ClearingChannel2Code? ClearingChannel { get; }

    /// <summary>
    /// User community specific instrument required for use within that user community.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    [IsoId("_TGEXEdp-Ed-ak6NoX_4Aeg_-1918335259")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    IRestrictedProprietaryChoice? LocalInstrument { get; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details of the type of payment.
/// </summary>
[IsoId("_t4wH_FkyEeGeoaLUQk__nA_-155389636")]
[DisplayName("Payment Type Information")]
public record PaymentTypeInformation25
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_t45R4FkyEeGeoaLUQk__nA_2129620802")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_t45R4VkyEeGeoaLUQk__nA_-909207484")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_t45R4lkyEeGeoaLUQk__nA_-747077953")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_t45R41kyEeGeoaLUQk__nA_-866245542")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <summary>
    /// Identifies the direct debit sequence, such as first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_t45R5FkyEeGeoaLUQk__nA_-1258954909")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType3Code? SequenceType { get; init; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_t5DC4FkyEeGeoaLUQk__nA_-790147494")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

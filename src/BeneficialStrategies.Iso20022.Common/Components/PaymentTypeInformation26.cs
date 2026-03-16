// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details of the type of payment.
/// </summary>
[IsoId("_YPH8YXR0EeiH1ZOt2UD8vQ")]
[DisplayName("Payment Type Information")]
public record PaymentTypeInformation26
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_YaAWs3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_YaAWtXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<ServiceLevel8Choice_> ServiceLevel { get; init; } = [];

    /// <summary>
    /// User community specific instrument.||Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_YaAWt3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [IsoId("_YaAWuXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

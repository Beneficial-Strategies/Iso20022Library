// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment instruction.
/// </summary>
[IsoId("_yVSsYZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Payment Instruction")]
public record PaymentInstruction27
{
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.|.
    /// </summary>
    [IsoId("_ydNSQ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public Instruction1Code? Instruction { get; init; }

    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [IsoId("_ydNSRZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PaymentType4Choice_? Type { get; init; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    [IsoId("_ydNSR5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityCode3Choice_? Priority { get; init; }

    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    [IsoId("_ydNSSZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; }
}

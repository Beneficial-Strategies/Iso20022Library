// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation25"/>
[IsoId("_t4wH_FkyEeGeoaLUQk__nA_-155389636")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation25
{
    /// <inheritdoc cref="IPaymentTypeInformation25.InstructionPriority"/>
    [IsoId("_t45R4FkyEeGeoaLUQk__nA_2129620802")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation25.ClearingChannel"/>
    [IsoId("_t45R4VkyEeGeoaLUQk__nA_-909207484")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation25.ServiceLevel"/>
    [IsoId("_t45R4lkyEeGeoaLUQk__nA_-747077953")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation25.LocalInstrument"/>
    [IsoId("_t45R41kyEeGeoaLUQk__nA_-866245542")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation25.SequenceType"/>
    [IsoId("_t45R5FkyEeGeoaLUQk__nA_-1258954909")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType3Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation25.CategoryPurpose"/>
    [IsoId("_t5DC4FkyEeGeoaLUQk__nA_-790147494")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation24"/>
[IsoId("_t5DC4VkyEeGeoaLUQk__nA_2129090901")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation24
{
    /// <inheritdoc cref="IPaymentTypeInformation24.InstructionPriority"/>
    [IsoId("_t5DC4lkyEeGeoaLUQk__nA_-909737385")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation24.ServiceLevel"/>
    [IsoId("_t5DC41kyEeGeoaLUQk__nA_-440929970")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation24.LocalInstrument"/>
    [IsoId("_t5DC5FkyEeGeoaLUQk__nA_1373205512")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation24.SequenceType"/>
    [IsoId("_t5Mz4FkyEeGeoaLUQk__nA_593158191")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType3Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation24.CategoryPurpose"/>
    [IsoId("_t5Mz4VkyEeGeoaLUQk__nA_-16576208")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

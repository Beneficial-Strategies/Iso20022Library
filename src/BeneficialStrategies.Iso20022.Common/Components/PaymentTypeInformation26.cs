// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation26"/>
[IsoId("_YPH8YXR0EeiH1ZOt2UD8vQ")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation26
{
    /// <inheritdoc cref="IPaymentTypeInformation26.InstructionPriority"/>
    [IsoId("_YaAWs3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation26.ServiceLevel"/>
    [IsoId("_YaAWtXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<ServiceLevel8Choice_> ServiceLevel { get; init; } = [];

    /// <inheritdoc cref="IPaymentTypeInformation26.LocalInstrument"/>
    [IsoId("_YaAWt3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation26.CategoryPurpose"/>
    [IsoId("_YaAWuXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

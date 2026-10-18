// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation29"/>
[IsoId("_gXVWIe10Eei2O5Op8j5zpA")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation29
{
    /// <inheritdoc cref="IPaymentTypeInformation29.InstructionPriority"/>
    [IsoId("_gk4C4-10Eei2O5Op8j5zpA")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation29.ServiceLevel"/>
    [IsoId("_gk4C5e10Eei2O5Op8j5zpA")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<ServiceLevel8Choice_> ServiceLevel { get; init; } = [];

    /// <inheritdoc cref="IPaymentTypeInformation29.LocalInstrument"/>
    [IsoId("_gk4C5-10Eei2O5Op8j5zpA")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation29.SequenceType"/>
    [IsoId("_gk4C6e10Eei2O5Op8j5zpA")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType3Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation29.CategoryPurpose"/>
    [IsoId("_gk4C6-10Eei2O5Op8j5zpA")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

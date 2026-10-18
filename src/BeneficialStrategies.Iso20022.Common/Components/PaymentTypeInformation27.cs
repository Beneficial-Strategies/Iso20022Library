// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation27"/>
[IsoId("_caAocXR0EeiH1ZOt2UD8vQ")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation27
{
    /// <inheritdoc cref="IPaymentTypeInformation27.InstructionPriority"/>
    [IsoId("_clCMs3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation27.ClearingChannel"/>
    [IsoId("_clCMtXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation27.ServiceLevel"/>
    [IsoId("_clCMt3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<ServiceLevel8Choice_> ServiceLevel { get; init; } = [];

    /// <inheritdoc cref="IPaymentTypeInformation27.LocalInstrument"/>
    [IsoId("_clCMuXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation27.SequenceType"/>
    [IsoId("_clCMu3R0EeiH1ZOt2UD8vQ")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType3Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation27.CategoryPurpose"/>
    [IsoId("_clCMvXR0EeiH1ZOt2UD8vQ")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

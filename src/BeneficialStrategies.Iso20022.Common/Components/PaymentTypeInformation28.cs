// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation28"/>
[IsoId("_PK3cAYkMEei-69PNFxn_Ew")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation28
{
    /// <inheritdoc cref="IPaymentTypeInformation28.InstructionPriority"/>
    [IsoId("_PVTKY4kMEei-69PNFxn_Ew")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation28.ClearingChannel"/>
    [IsoId("_PVTKZYkMEei-69PNFxn_Ew")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation28.ServiceLevel"/>
    [IsoId("_PVTKZ4kMEei-69PNFxn_Ew")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ValueList<ServiceLevel8Choice_> ServiceLevel { get; init; } = [];

    /// <inheritdoc cref="IPaymentTypeInformation28.LocalInstrument"/>
    [IsoId("_PVTKaYkMEei-69PNFxn_Ew")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation28.CategoryPurpose"/>
    [IsoId("_PVTKa4kMEei-69PNFxn_Ew")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

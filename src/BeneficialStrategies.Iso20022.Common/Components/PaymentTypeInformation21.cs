// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation21"/>
[IsoId("_THQp4Np-Ed-ak6NoX_4Aeg_40856737")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation21
{
    /// <inheritdoc cref="IPaymentTypeInformation21.InstructionPriority"/>
    [IsoId("_THQp4dp-Ed-ak6NoX_4Aeg_40856798")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation21.ClearingChannel"/>
    [IsoId("_THQp4tp-Ed-ak6NoX_4Aeg_40856859")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation21.ServiceLevel"/>
    [IsoId("_THQp49p-Ed-ak6NoX_4Aeg_40857383")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation21.LocalInstrument"/>
    [IsoId("_THQp5Np-Ed-ak6NoX_4Aeg_40857292")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation21.CategoryPurpose"/>
    [IsoId("_THQp5dp-Ed-ak6NoX_4Aeg_277971084")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

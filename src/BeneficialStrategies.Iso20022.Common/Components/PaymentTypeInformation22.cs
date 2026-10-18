// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation22"/>
[IsoId("_THQp5tp-Ed-ak6NoX_4Aeg_594971445")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation22
{
    /// <inheritdoc cref="IPaymentTypeInformation22.InstructionPriority"/>
    [IsoId("_THQp59p-Ed-ak6NoX_4Aeg_595893874")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation22.ClearingChannel"/>
    [IsoId("_THQp6Np-Ed-ak6NoX_4Aeg_595894018")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation22.ServiceLevel"/>
    [IsoId("_THaa4Np-Ed-ak6NoX_4Aeg_595894420")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation22.LocalInstrument"/>
    [IsoId("_THaa4dp-Ed-ak6NoX_4Aeg_595894358")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation22.SequenceType"/>
    [IsoId("_THaa4tp-Ed-ak6NoX_4Aeg_595894049")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation22.CategoryPurpose"/>
    [IsoId("_THaa49p-Ed-ak6NoX_4Aeg_-1827048269")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation19"/>
[IsoId("_TGq0Cdp-Ed-ak6NoX_4Aeg_-192814839")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation19
{
    /// <inheritdoc cref="IPaymentTypeInformation19.InstructionPriority"/>
    [IsoId("_TGq0Ctp-Ed-ak6NoX_4Aeg_-192814807")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation19.ServiceLevel"/>
    [IsoId("_TG9u8Np-Ed-ak6NoX_4Aeg_-192814402")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation19.LocalInstrument"/>
    [IsoId("_THHf8Np-Ed-ak6NoX_4Aeg_-192814345")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation19.CategoryPurpose"/>
    [IsoId("_THHf8dp-Ed-ak6NoX_4Aeg_-449762134")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

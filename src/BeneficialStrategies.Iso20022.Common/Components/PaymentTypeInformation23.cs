// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation23"/>
[IsoId("_THaa59p-Ed-ak6NoX_4Aeg_1200511056")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation23
{
    /// <inheritdoc cref="IPaymentTypeInformation23.InstructionPriority"/>
    [IsoId("_THaa6Np-Ed-ak6NoX_4Aeg_1200511117")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation23.ClearingChannel"/>
    [IsoId("_THkL4Np-Ed-ak6NoX_4Aeg_1200511148")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation23.ServiceLevel"/>
    [IsoId("_THkL4dp-Ed-ak6NoX_4Aeg_1200511211")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation23.LocalInstrument"/>
    [IsoId("_THkL4tp-Ed-ak6NoX_4Aeg_1200511241")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }
}

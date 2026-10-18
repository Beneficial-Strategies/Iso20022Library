// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation5"/>
[IsoId("_TF7NJdp-Ed-ak6NoX_4Aeg_622781299")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation5
{
    /// <inheritdoc cref="IPaymentTypeInformation5.InstructionPriority"/>
    [IsoId("_TF7NJtp-Ed-ak6NoX_4Aeg_622781702")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation5.ServiceLevel"/>
    [IsoId("_TF7NJ9p-Ed-ak6NoX_4Aeg_622781762")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public RestrictedProprietaryChoice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation5.ClearingChannel"/>
    [IsoId("_TGEXENp-Ed-ak6NoX_4Aeg_-1369500381")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation5.LocalInstrument"/>
    [IsoId("_TGEXEdp-Ed-ak6NoX_4Aeg_-1918335259")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public RestrictedProprietaryChoice_? LocalInstrument { get; init; }
}

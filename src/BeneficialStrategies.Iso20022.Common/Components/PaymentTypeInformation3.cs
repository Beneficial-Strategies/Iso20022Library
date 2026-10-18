// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation3"/>
[IsoId("_TGOIE9p-Ed-ak6NoX_4Aeg_926240939")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation3
{
    /// <inheritdoc cref="IPaymentTypeInformation3.InstructionPriority"/>
    [IsoId("_TGOIFNp-Ed-ak6NoX_4Aeg_1174666100")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation3.ServiceLevel"/>
    [IsoId("_TGOIFdp-Ed-ak6NoX_4Aeg_1288260951")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel2Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation3.ClearingChannel"/>
    [IsoId("_TGOIFtp-Ed-ak6NoX_4Aeg_2008409724")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation3.LocalInstrument"/>
    [IsoId("_TGOIF9p-Ed-ak6NoX_4Aeg_-1900524089")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation3.CategoryPurpose"/>
    [IsoId("_TGOIGNp-Ed-ak6NoX_4Aeg_2008410121")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}

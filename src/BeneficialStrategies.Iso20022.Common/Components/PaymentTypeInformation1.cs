// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation1"/>
[IsoId("_TGX5Gdp-Ed-ak6NoX_4Aeg_-1770135216")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation1
{
    /// <inheritdoc cref="IPaymentTypeInformation1.InstructionPriority"/>
    [IsoId("_TGX5Gtp-Ed-ak6NoX_4Aeg_-1770135121")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation1.ServiceLevel"/>
    [IsoId("_TGhDANp-Ed-ak6NoX_4Aeg_-1770134172")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel2Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation1.ClearingChannel"/>
    [IsoId("_TGhDAdp-Ed-ak6NoX_4Aeg_-1770135078")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation1.LocalInstrument"/>
    [IsoId("_TGhDAtp-Ed-ak6NoX_4Aeg_-1770133337")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation1.CategoryPurpose"/>
    [IsoId("_TGhDA9p-Ed-ak6NoX_4Aeg_-1770134397")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}

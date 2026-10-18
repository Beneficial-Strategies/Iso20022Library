// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation4"/>
[IsoId("_TGEXFdp-Ed-ak6NoX_4Aeg_-327330961")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation4
{
    /// <inheritdoc cref="IPaymentTypeInformation4.InstructionPriority"/>
    [IsoId("_TGEXFtp-Ed-ak6NoX_4Aeg_-327330935")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation4.ServiceLevel"/>
    [IsoId("_TGEXF9p-Ed-ak6NoX_4Aeg_-327330683")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel3Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation4.ClearingChannel"/>
    [IsoId("_TGEXGNp-Ed-ak6NoX_4Aeg_139967667")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation4.LocalInstrument"/>
    [IsoId("_TGEXGdp-Ed-ak6NoX_4Aeg_-1930237022")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation4.SequenceType"/>
    [IsoId("_TGEXGtp-Ed-ak6NoX_4Aeg_139967720")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation4.CategoryPurpose"/>
    [IsoId("_TGEXG9p-Ed-ak6NoX_4Aeg_496446817")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}

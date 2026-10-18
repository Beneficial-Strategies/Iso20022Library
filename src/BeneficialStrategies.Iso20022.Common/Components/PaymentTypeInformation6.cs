// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation6"/>
[IsoId("_TGhDCtp-Ed-ak6NoX_4Aeg_-579871579")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation6
{
    /// <inheritdoc cref="IPaymentTypeInformation6.InstructionPriority"/>
    [IsoId("_TGq0ANp-Ed-ak6NoX_4Aeg_-579871562")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation6.ServiceLevel"/>
    [IsoId("_TGq0Adp-Ed-ak6NoX_4Aeg_-579871448")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel2Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation6.ClearingChannel"/>
    [IsoId("_TGq0Atp-Ed-ak6NoX_4Aeg_-579871544")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation6.LocalInstrument"/>
    [IsoId("_TGq0A9p-Ed-ak6NoX_4Aeg_-579871189")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation6.SequenceType"/>
    [IsoId("_TGq0BNp-Ed-ak6NoX_4Aeg_1750627501")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation6.CategoryPurpose"/>
    [IsoId("_TGq0Bdp-Ed-ak6NoX_4Aeg_-579871509")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}

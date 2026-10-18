// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation2"/>
[IsoId("_TGOIHNp-Ed-ak6NoX_4Aeg_1553288143")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation2
{
    /// <inheritdoc cref="IPaymentTypeInformation2.InstructionPriority"/>
    [IsoId("_TGX5ENp-Ed-ak6NoX_4Aeg_1553288455")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation2.ServiceLevel"/>
    [IsoId("_TGX5Edp-Ed-ak6NoX_4Aeg_1553288962")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel3Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation2.ClearingChannel"/>
    [IsoId("_TGX5Etp-Ed-ak6NoX_4Aeg_1553288515")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation2.LocalInstrument"/>
    [IsoId("_TGX5E9p-Ed-ak6NoX_4Aeg_1553289894")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation2.SequenceType"/>
    [IsoId("_TGX5FNp-Ed-ak6NoX_4Aeg_1553288550")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation2.CategoryPurpose"/>
    [IsoId("_TGX5Fdp-Ed-ak6NoX_4Aeg_1553288876")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}

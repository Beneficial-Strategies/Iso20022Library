// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTypeInformation20"/>
[IsoId("_THHf8tp-Ed-ak6NoX_4Aeg_1994885996")]
[DisplayName("Payment Type Information")]
public partial record PaymentTypeInformation20
{
    /// <inheritdoc cref="IPaymentTypeInformation20.InstructionPriority"/>
    [IsoId("_THHf89p-Ed-ak6NoX_4Aeg_1994885998")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation20.ServiceLevel"/>
    [IsoId("_THHf9Np-Ed-ak6NoX_4Aeg_1994886544")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation20.LocalInstrument"/>
    [IsoId("_THHf9dp-Ed-ak6NoX_4Aeg_1994886513")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation20.SequenceType"/>
    [IsoId("_THHf9tp-Ed-ak6NoX_4Aeg_1994886359")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <inheritdoc cref="IPaymentTypeInformation20.CategoryPurpose"/>
    [IsoId("_THHf99p-Ed-ak6NoX_4Aeg_-103441251")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }
}

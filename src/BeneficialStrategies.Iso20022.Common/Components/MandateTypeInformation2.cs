// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateTypeInformation2"/>
[IsoId("_cm369kjwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Type Information")]
public partial record MandateTypeInformation2
{
    /// <inheritdoc cref="IMandateTypeInformation2.ServiceLevel"/>
    [IsoId("_cvK7QUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <inheritdoc cref="IMandateTypeInformation2.LocalInstrument"/>
    [IsoId("_cvK7Q0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }

    /// <inheritdoc cref="IMandateTypeInformation2.CategoryPurpose"/>
    [IsoId("_T6WPoUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public CategoryPurpose1Choice_? CategoryPurpose { get; init; }

    /// <inheritdoc cref="IMandateTypeInformation2.Classification"/>
    [IsoId("_3MJbIGVREeacpJ-gG9kyUQ")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public MandateClassification1Choice_? Classification { get; init; }
}

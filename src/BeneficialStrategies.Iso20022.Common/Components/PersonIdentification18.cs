// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPersonIdentification18"/>
[IsoId("_-9oltTFLEe651u5xu3f5iw")]
[DisplayName("Person Identification18")]
public partial record PersonIdentification18
{
    /// <inheritdoc cref="IPersonIdentification18.DateAndPlaceOfBirth"/>
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

    /// <inheritdoc cref="IPersonIdentification18.Other"/>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericPersonIdentification2> Other { get; init; } = [];
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Person Identification18.
/// </summary>
[IsoId("_-9oltTFLEe651u5xu3f5iw")]
[DisplayName("Person Identification18")]
public partial record PersonIdentification18
{
    #nullable enable

    /// <summary>
    /// Date And Place Of Birth.
    /// </summary>
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<GenericPersonIdentification2> Other { get; init; } = [];

    
    #nullable disable
    
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QENIltp-Ed-ak6NoX_4Aeg_1626106351")]
[DisplayName("Person Identification")]
public record PersonIdentification5
{
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_QENIl9p-Ed-ak6NoX_4Aeg_1634415117")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_QENImNp-Ed-ak6NoX_4Aeg_1634415136")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public GenericPersonIdentification1? Other { get; init; }
}

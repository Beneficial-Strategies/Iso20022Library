// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_OIOBdPfUEei89sMSHxl1ew")]
[DisplayName("Party Identification")]
public record PartyIdentification210
{
    /// <summary>
    /// Contains the personal ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBdffUEei89sMSHxl1ew")]
    [DisplayName("Personal Identification")]
    [IsoXmlTag("PrsnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PersonalIdentification { get; init; }

    /// <summary>
    /// Contains the company-provided ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBd_fUEei89sMSHxl1ew")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? EmployeeIdentification { get; init; }

    /// <summary>
    /// Contains the name of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_OIOBdvfUEei89sMSHxl1ew")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Contains the professional level of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_h0HkUPfUEei89sMSHxl1ew")]
    [DisplayName("Professional Level")]
    [IsoXmlTag("PrfssnlLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProfessionalLevel { get; init; }
}

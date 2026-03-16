// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet vehicle driver.
/// </summary>
[IsoId("_1QhmuPilEeiJaN6-Lf-c_w")]
[DisplayName("Driver")]
public record Driver1
{
    /// <summary>
    /// Name of fleet driver.
    /// </summary>
    [IsoId("_Pe4noP2hEeiS2rs-hXBB5Q")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Fleet driver identification.
    /// </summary>
    [IsoId("_YI80wf2hEeiS2rs-hXBB5Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_1QhmvvilEeiJaN6-Lf-c_w")]
    [DisplayName("Driving License")]
    [IsoXmlTag("DrvgLic")]
    public DrivingLicense1? DrivingLicense { get; init; }

    /// <summary>
    /// Contains the employer information.
    /// </summary>
    [IsoId("_9VMyU_imEeiJaN6-Lf-c_w")]
    [DisplayName("Employer")]
    [IsoXmlTag("Mplyr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Employer { get; init; }

    /// <summary>
    /// Contains the employee identification number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_9VMyVPimEeiJaN6-Lf-c_w")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? EmployeeIdentification { get; init; }

    /// <summary>
    /// Contains the fleet driver&apos;s department number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_9VMyVfimEeiJaN6-Lf-c_w")]
    [DisplayName("Department Number")]
    [IsoXmlTag("DeptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DepartmentNumber { get; init; }

    /// <summary>
    /// Additional identification used for the driver.
    /// </summary>
    [IsoId("_1QhmufilEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public TravelDocument1? AdditionalIdentification { get; init; }

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_1QhmvPilEeiJaN6-Lf-c_w")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Additional fleet summary-level information.
    /// </summary>
    [IsoId("_aXigIPinEeiJaN6-Lf-c_w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}

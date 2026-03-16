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
[IsoId("_Xa1IQRytEey6gI8SKlv7rg")]
[DisplayName("Driver")]
public record Driver2
{
    /// <summary>
    /// Name of fleet driver.
    /// </summary>
    [IsoId("_XkokgRytEey6gI8SKlv7rg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Fleet driver identification.
    /// </summary>
    [IsoId("_XkokgxytEey6gI8SKlv7rg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; }

    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_XkokhRytEey6gI8SKlv7rg")]
    [DisplayName("Driving License")]
    [IsoXmlTag("DrvgLic")]
    public DrivingLicense2? DrivingLicense { get; init; }

    /// <summary>
    /// Contains the employer information.
    /// </summary>
    [IsoId("_XkokhxytEey6gI8SKlv7rg")]
    [DisplayName("Employer")]
    [IsoXmlTag("Mplyr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Employer { get; init; }

    /// <summary>
    /// Contains the employee identification number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_XkokiRytEey6gI8SKlv7rg")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? EmployeeIdentification { get; init; }

    /// <summary>
    /// Contains the fleet driver&apos;s department number as assigned by the fleet operator.
    /// </summary>
    [IsoId("_XkokixytEey6gI8SKlv7rg")]
    [DisplayName("Department Number")]
    [IsoXmlTag("DeptNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DepartmentNumber { get; init; }

    /// <summary>
    /// Additional identification used for the driver.
    /// </summary>
    [IsoId("_XkokjRytEey6gI8SKlv7rg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public TravelDocument2? AdditionalIdentification { get; init; }

    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_XkokjxytEey6gI8SKlv7rg")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Additional fleet summary-level information.
    /// </summary>
    [IsoId("_XkokkRytEey6gI8SKlv7rg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}

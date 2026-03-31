// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of driving license.
/// </summary>
[IsoId("_9wWuIRysEey6gI8SKlv7rg")]
[DisplayName("Driving License")]
public record DrivingLicense2
{
    /// <summary>
    /// Type of driving license.
    /// </summary>
    [IsoId("_92ub4BysEey6gI8SKlv7rg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Type { get; init; }

    /// <summary>
    /// Form of driving license.
    /// </summary>
    [IsoId("_92ub4hysEey6gI8SKlv7rg")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; }

    /// <summary>
    /// Identification of the driver license (for example, driver license number).
    /// </summary>
    [IsoId("_92ub5BysEey6gI8SKlv7rg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Authority assigning an identification to a driver license.
    /// </summary>
    [IsoId("_92ub5hysEey6gI8SKlv7rg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public LegalStructure1Code? Assigner { get; init; }

    /// <summary>
    /// Date of issuance of the driving license.
    /// </summary>
    [IsoId("_92ub6BysEey6gI8SKlv7rg")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of the driving license (if and when relevant).
    /// </summary>
    [IsoId("_92ub6hysEey6gI8SKlv7rg")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the driver license.
    /// </summary>
    [IsoId("_92ub7BysEey6gI8SKlv7rg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    /// <summary>
    /// State issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_92ub7hysEey6gI8SKlv7rg")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? State { get; init; }

    /// <summary>
    /// Province issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_92ub8BysEey6gI8SKlv7rg")]
    [DisplayName("Province")]
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Province { get; init; }

    /// <summary>
    /// Other authority issuing a driver license.
    /// </summary>
    [IsoId("_92ub8hysEey6gI8SKlv7rg")]
    [DisplayName("Other Authority")]
    [IsoXmlTag("OthrAuthrty")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? OtherAuthority { get; init; }
}

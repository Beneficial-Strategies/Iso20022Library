// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the the status of a legally recognized subject or national of a particular country.
/// </summary>
[IsoId("_hRQnYQ2bEeSNWNtJlXOAhg")]
[DisplayName("Citizenship Information")]
public record CitizenshipInformation1
{
    /// <summary>
    /// Specifies the country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    [IsoId("_nGXZkA2bEeSNWNtJlXOAhg")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public required NationalityCode Nationality { get; init; }

    /// <summary>
    /// Indicates whether the person is a legal minor. It may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    [IsoId("_pxKL4A2bEeSNWNtJlXOAhg")]
    [DisplayName("Minor Indicator")]
    [IsoXmlTag("MnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MinorIndicator { get; init; }

    /// <summary>
    /// Date of the commencement of citizenship.
    /// </summary>
    [IsoId("_ssmpUA2bEeSNWNtJlXOAhg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Date of the end of citizenship.
    /// </summary>
    [IsoId("_vsqhAA2bEeSNWNtJlXOAhg")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }
}

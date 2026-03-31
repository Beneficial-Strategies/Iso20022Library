// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on a system or a member of the system.
/// </summary>
[IsoId("_RD_KlNp-Ed-ak6NoX_4Aeg_5460592")]
[DisplayName("System Return Criteria")]
public record SystemReturnCriteria2
{
    /// <summary>
    /// Indicates whether the system identification is requested.
    /// </summary>
    [IsoId("_RD_Kldp-Ed-ak6NoX_4Aeg_5460611")]
    [DisplayName("System Identification Indicator")]
    [IsoXmlTag("SysIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SystemIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the member identification is requested.
    /// </summary>
    [IsoId("_RD_Kltp-Ed-ak6NoX_4Aeg_5460652")]
    [DisplayName("Member Identification Indicator")]
    [IsoXmlTag("MmbIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MemberIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the country identification is requested.
    /// </summary>
    [IsoId("_RD_Kl9p-Ed-ak6NoX_4Aeg_348086000")]
    [DisplayName("Country Identification Indicator")]
    [IsoXmlTag("CtryIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CountryIdentificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account identification is requested.
    /// </summary>
    [IsoId("_RD_KmNp-Ed-ak6NoX_4Aeg_762169796")]
    [DisplayName("Account Identification Indicator")]
    [IsoXmlTag("AcctIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountIdentificationIndicator { get; init; }
}

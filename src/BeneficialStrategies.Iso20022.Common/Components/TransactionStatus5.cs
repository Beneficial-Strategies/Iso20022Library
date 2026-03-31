// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the future status of the transaction by means of a code and a period.
/// </summary>
[IsoId("_RbFb9Np-Ed-ak6NoX_4Aeg_-2036389843")]
[DisplayName("Transaction Status")]
public record TransactionStatus5
{
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbFb9dp-Ed-ak6NoX_4Aeg_-2036389841")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus3Code Status { get; init; }

    /// <summary>
    /// Date and time at which the current status will change.
    /// </summary>
    [IsoId("_RbFb9tp-Ed-ak6NoX_4Aeg_-2036389782")]
    [DisplayName("Change Date Time")]
    [IsoXmlTag("ChngDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ChangeDateTime { get; init; }

    /// <summary>
    /// Additional information on the reason for the time-out.
    /// </summary>
    [IsoId("_RbFb99p-Ed-ak6NoX_4Aeg_-149402521")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }
}

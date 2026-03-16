// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Decision of the voting party for one resolution. Several types of decisions can be indicated to allow for split vote specification.
/// </summary>
[IsoId("_8pNRsV61EeSjaerr_EM7AQ")]
[DisplayName("Vote")]
public record Vote6
{
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_9Gg4w161EeSjaerr_EM7AQ")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_9Gg4xV61EeSjaerr_EM7AQ")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? For { get; init; }

    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_9Gg4x161EeSjaerr_EM7AQ")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Against { get; init; }

    /// <summary>
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    [IsoId("_9Gg4yV61EeSjaerr_EM7AQ")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Abstain { get; init; }

    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_9Gg4y161EeSjaerr_EM7AQ")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Withhold { get; init; }

    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_9Gg4zV61EeSjaerr_EM7AQ")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? WithManagement { get; init; }

    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_9Gg4z161EeSjaerr_EM7AQ")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AgainstManagement { get; init; }

    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_9Gg40V61EeSjaerr_EM7AQ")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Discretionary { get; init; }

    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_SdMMU16_EeSjaerr_EM7AQ")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? OneYear { get; init; }

    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_SdMMVF6_EeSjaerr_EM7AQ")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TwoYears { get; init; }

    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_SdMMVV6_EeSjaerr_EM7AQ")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ThreeYears { get; init; }

    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_9Gg40161EeSjaerr_EM7AQ")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NoAction { get; init; }

    /// <summary>
    /// Resolution withdrawn at the meeting.
    /// </summary>
    [IsoId("_GlQEEF62EeSjaerr_EM7AQ")]
    [DisplayName("Withdrawn")]
    [IsoXmlTag("Wdrwn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Withdrawn { get; init; }
}

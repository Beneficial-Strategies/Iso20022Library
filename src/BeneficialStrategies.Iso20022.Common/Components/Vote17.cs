// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_K1MqoTUGEe2tRf29bleifQ")]
[DisplayName("Vote")]
public record Vote17
{
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_LMABEzUGEe2tRf29bleifQ")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Language, title and textual description of an agenda resolution.
    /// </summary>
    [IsoId("_IZCKMTUGEe2tRf29bleifQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription1> Description { get; init; } = [];

    /// <summary>
    /// Specifies whether the resolution is a new or an amended resolution.
    /// </summary>
    [IsoId("_rydV4DUGEe2tRf29bleifQ")]
    [DisplayName("Sub Status")]
    [IsoXmlTag("SubSts")]
    public ResolutionSubStatus1Code? SubStatus { get; init; }

    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_LMABFTUGEe2tRf29bleifQ")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public FinancialInstrumentQuantity18Choice_? For { get; init; }

    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_LMABFzUGEe2tRf29bleifQ")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public FinancialInstrumentQuantity18Choice_? Against { get; init; }

    /// <summary>
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    [IsoId("_LMABGTUGEe2tRf29bleifQ")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; }

    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_LMABGzUGEe2tRf29bleifQ")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; }

    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_LMABHTUGEe2tRf29bleifQ")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; }

    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_LMABHzUGEe2tRf29bleifQ")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; }

    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_LMABITUGEe2tRf29bleifQ")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; }

    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_LMABIzUGEe2tRf29bleifQ")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; }

    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_LMABJTUGEe2tRf29bleifQ")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; }

    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_LMABJzUGEe2tRf29bleifQ")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; }

    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_LMABKTUGEe2tRf29bleifQ")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; }

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_LMABKzUGEe2tRf29bleifQ")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; }

    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_LMABLTUGEe2tRf29bleifQ")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = [];

    /// <summary>
    /// Indicates the resolution was withdrawn at the meeting.
    /// </summary>
    [IsoId("_LMABLzUGEe2tRf29bleifQ")]
    [DisplayName("Withdrawn")]
    [IsoXmlTag("Wdrwn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Withdrawn { get; init; }
}

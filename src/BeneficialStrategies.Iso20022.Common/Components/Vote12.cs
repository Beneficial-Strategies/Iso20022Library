// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote results for one resolution.
/// </summary>
[IsoId("_Uunw0a-3EemJ1NnLPsTFaw")]
[DisplayName("Vote")]
public record Vote12
{
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_VCjZc6-3EemJ1NnLPsTFaw")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Acceptance status of the resolution.
    /// </summary>
    [IsoId("_VCjZda-3EemJ1NnLPsTFaw")]
    [DisplayName("Resolution Status")]
    [IsoXmlTag("RsltnSts")]
    public required ResolutionStatus2Code ResolutionStatus { get; init; }

    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_VCjZd6-3EemJ1NnLPsTFaw")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public FinancialInstrumentQuantity18Choice_? For { get; init; }

    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_VCjZea-3EemJ1NnLPsTFaw")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public FinancialInstrumentQuantity18Choice_? Against { get; init; }

    /// <summary>
    /// Number of abstention votes.
    /// </summary>
    [IsoId("_VCjZe6-3EemJ1NnLPsTFaw")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; }

    /// <summary>
    /// Total votes withheld, for example, in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    [IsoId("_VCjZfa-3EemJ1NnLPsTFaw")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; }

    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_SavCpa-3EemJ1NnLPsTFaw")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; }

    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_SavCpq-3EemJ1NnLPsTFaw")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; }

    /// <summary>
    /// Number of votes for which the decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_SavCp6-3EemJ1NnLPsTFaw")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; }

    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VCjZf6-3EemJ1NnLPsTFaw")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; }

    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VCjZga-3EemJ1NnLPsTFaw")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; }

    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_VCjZg6-3EemJ1NnLPsTFaw")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; }

    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_VCjZha-3EemJ1NnLPsTFaw")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; }

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_SavCqK-3EemJ1NnLPsTFaw")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; }

    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_SavCqa-3EemJ1NnLPsTFaw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryVote2? Proprietary { get; init; }
}

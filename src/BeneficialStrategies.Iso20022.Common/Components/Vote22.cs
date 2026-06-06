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
[IsoId("_M7uL4ajIEfCzuLlmLrhIvA")]
[DisplayName("Vote22")]
public record Vote22
{
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_NDMF0ajIEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Language, title and textual description of an agenda resolution. 
    /// </summary>
    [IsoId("_NDMF06jIEfCzuLlmLrhIvA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription2> Description { get; init; } = [];

    /// <summary>
    /// Specifies whether the resolution is a new or an amended resolution.
    /// </summary>
    [IsoId("_NDMF1ajIEfCzuLlmLrhIvA")]
    [DisplayName("Sub Status")]
    [IsoXmlTag("SubSts")]
    public ResolutionSubStatus1Code? SubStatus { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour is instructed.
    /// </summary>
    [IsoId("_NDMF16jIEfCzuLlmLrhIvA")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public FinancialInstrumentQuantity18Choice_? For { get; init; }

    /// <summary>
    /// Number of securities for which vote against is instructed.
    /// </summary>
    [IsoId("_NDMF2ajIEfCzuLlmLrhIvA")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public FinancialInstrumentQuantity18Choice_? Against { get; init; }

    /// <summary>
    /// Number of securities for which vote to abstain is instructed.
    /// </summary>
    [IsoId("_NDMF26jIEfCzuLlmLrhIvA")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; }

    /// <summary>
    /// Number of securities for which vote to withhold is instructed.
    /// </summary>
    [IsoId("_NDMF3ajIEfCzuLlmLrhIvA")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; }

    /// <summary>
    /// Number of securities for which vote in line with the votes of the management is instructed.
    /// </summary>
    [IsoId("_NDMF36jIEfCzuLlmLrhIvA")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; }

    /// <summary>
    /// Number of securities for which vote against the voting recommendation of the management is instructed.
    /// </summary>
    [IsoId("_NDMF4ajIEfCzuLlmLrhIvA")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; }

    /// <summary>
    /// Number of securities for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_NDMF46jIEfCzuLlmLrhIvA")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour for one year for 'say on pay' type of resolution is instructed.
    /// </summary>
    [IsoId("_NDMF5ajIEfCzuLlmLrhIvA")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour of two years for 'say on pay' type of resolution is instructed.
    /// </summary>
    [IsoId("_NDMF56jIEfCzuLlmLrhIvA")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; }

    /// <summary>
    /// Number of securities for which vote in favour of three years for 'say on pay' type of resolution is instructed.
    /// </summary>
    [IsoId("_NDMF6ajIEfCzuLlmLrhIvA")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; }

    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_NDMF66jIEfCzuLlmLrhIvA")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; }

    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_NDMF7ajIEfCzuLlmLrhIvA")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; }

    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_NDMF76jIEfCzuLlmLrhIvA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = [];

    /// <summary>
    /// Indicates the resolution was withdrawn at the meeting.
    /// </summary>
    [IsoId("_NDMF8ajIEfCzuLlmLrhIvA")]
    [DisplayName("Withdrawn")]
    [IsoXmlTag("Wdrwn")]
    public IsoYesNoIndicator? Withdrawn { get; init; }
}

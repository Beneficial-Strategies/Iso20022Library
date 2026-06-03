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
    [IsoId("_NDMF0ajIEfCzuLlmLrhIvA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required IsoMax35Text IssuerLabel { get; init; }

    [IsoId("_NDMF06jIEfCzuLlmLrhIvA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription2> Description { get; init; } = [];

    [IsoId("_NDMF1ajIEfCzuLlmLrhIvA")]
    [DisplayName("Sub Status")]
    [IsoXmlTag("SubSts")]
    public ResolutionSubStatus1Code? SubStatus { get; init; }

    [IsoId("_NDMF16jIEfCzuLlmLrhIvA")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    public FinancialInstrumentQuantity18Choice_? For { get; init; }

    [IsoId("_NDMF2ajIEfCzuLlmLrhIvA")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    public FinancialInstrumentQuantity18Choice_? Against { get; init; }

    [IsoId("_NDMF26jIEfCzuLlmLrhIvA")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; }

    [IsoId("_NDMF3ajIEfCzuLlmLrhIvA")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; }

    [IsoId("_NDMF36jIEfCzuLlmLrhIvA")]
    [DisplayName("With Management")]
    [IsoXmlTag("WthMgmt")]
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; }

    [IsoId("_NDMF4ajIEfCzuLlmLrhIvA")]
    [DisplayName("Against Management")]
    [IsoXmlTag("AgnstMgmt")]
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; }

    [IsoId("_NDMF46jIEfCzuLlmLrhIvA")]
    [DisplayName("Discretionary")]
    [IsoXmlTag("Dscrtnry")]
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; }

    [IsoId("_NDMF5ajIEfCzuLlmLrhIvA")]
    [DisplayName("One Year")]
    [IsoXmlTag("OneYr")]
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; }

    [IsoId("_NDMF56jIEfCzuLlmLrhIvA")]
    [DisplayName("Two Years")]
    [IsoXmlTag("TwoYrs")]
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; }

    [IsoId("_NDMF6ajIEfCzuLlmLrhIvA")]
    [DisplayName("Three Years")]
    [IsoXmlTag("ThreeYrs")]
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; }

    [IsoId("_NDMF66jIEfCzuLlmLrhIvA")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; }

    [IsoId("_NDMF7ajIEfCzuLlmLrhIvA")]
    [DisplayName("Blank")]
    [IsoXmlTag("Blnk")]
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; }

    [IsoId("_NDMF76jIEfCzuLlmLrhIvA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = [];

    [IsoId("_NDMF8ajIEfCzuLlmLrhIvA")]
    [DisplayName("Withdrawn")]
    [IsoXmlTag("Wdrwn")]
    public IsoYesNoIndicator? Withdrawn { get; init; }
}

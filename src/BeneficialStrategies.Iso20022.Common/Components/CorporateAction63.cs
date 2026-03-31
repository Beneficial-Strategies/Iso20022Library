// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_mzDx8Rn5EeyroI8qKgB7Mg")]
[DisplayName("Corporate Action")]
public record CorporateAction63
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_nJtXYRn5EeyroI8qKgB7Mg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate59? DateDetails { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_nJtXYxn5EeyroI8qKgB7Mg")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat14Choice_? EventStage { get; init; }

    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_nJtXZRn5EeyroI8qKgB7Mg")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public AdditionalBusinessProcessFormat11Choice_? AdditionalBusinessProcessIndicator { get; init; }

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_qLbb8Rn5EeyroI8qKgB7Mg")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_nJtXbRn5EeyroI8qKgB7Mg")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; }
}

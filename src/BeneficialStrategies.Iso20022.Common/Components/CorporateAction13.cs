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
[IsoId("_QpbJUCUmEeO8eOSw0QN9mA")]
[DisplayName("Corporate Action")]
public record CorporateAction13
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_W395kT_dEeOO5biOFQYL8w")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate30? DateDetails { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_iTlzECUoEeO8eOSw0QN9mA")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat6Choice_? EventStage { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_SU9WtCUpEeO8eOSw0QN9mA")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat1Choice_? LotteryType { get; init; }
}

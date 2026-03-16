// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to qualify the interest rate.
/// </summary>
[IsoId("_uoQ2MbTVEee_k7HqaUKERA")]
[DisplayName("Rate")]
public record Rate4
{
    /// <summary>
    /// Specifies the type of interest rate.
    /// </summary>
    [IsoId("_uwTX47TVEee_k7HqaUKERA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required RateType4Choice_ Type { get; init; }

    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    [IsoId("_uwTX5bTVEee_k7HqaUKERA")]
    [DisplayName("Validity Range")]
    [IsoXmlTag("VldtyRg")]
    public ActiveOrHistoricCurrencyAndAmountRange2? ValidityRange { get; init; }
}

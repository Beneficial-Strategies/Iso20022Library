// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
    /// </summary>
    [IsoId("_w2B750ABEeCaq78Ig8ATcA")]
    [DisplayName("Response Status")]
    public record ResponseStatus : Status8Choice_ { }
}

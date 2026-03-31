// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status1Choice
{
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_UVDSsdp-Ed-ak6NoX_4Aeg_-1192179477")]
    [DisplayName("Corporate Action Event Stage")]
    public record CorporateActionEventStage : Status1Choice_ { }
}

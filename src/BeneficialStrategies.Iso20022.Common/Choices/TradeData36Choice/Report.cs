// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData36Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_Mxpko8K8EeuMhqg3CsEu6Q")]
    [DisplayName("Report")]
    public record Report : TradeData36Choice_ { }
}

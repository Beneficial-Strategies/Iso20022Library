// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRate1Choice
{
    /// <summary>
    /// The value of the rate is not specified, eg, the rate is unknown.
    /// </summary>
    [IsoId("_UPO-mtp-Ed-ak6NoX_4Aeg_1430735244")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : GrossDividendRate1Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice
{
    /// <summary>
    /// Parameter for which the estimated cash flow is being reported.
    /// </summary>
    [IsoId("_U1-1g9p-Ed-ak6NoX_4Aeg_-922147025")]
    [DisplayName("User Defined")]
    public record UserDefined : ReportParameter2Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account9Choice
{
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_XY2a5Np-Ed-ak6NoX_4Aeg_1986494181")]
    [DisplayName("Cash Account")]
    public record CashAccount : Account9Choice_ { }
}

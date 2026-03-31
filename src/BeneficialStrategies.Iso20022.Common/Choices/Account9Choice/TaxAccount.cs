// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account9Choice
{
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_XY_k0dp-Ed-ak6NoX_4Aeg_-1676267174")]
    [DisplayName("Tax Account")]
    public record TaxAccount : Account9Choice_ { }
}

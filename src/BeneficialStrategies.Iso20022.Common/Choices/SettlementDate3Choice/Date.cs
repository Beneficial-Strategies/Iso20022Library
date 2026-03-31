// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate3Choice
{
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_Qsl-R9p-Ed-ak6NoX_4Aeg_114969795")]
    [DisplayName("Date")]
    public record Date : SettlementDate3Choice_ { }
}

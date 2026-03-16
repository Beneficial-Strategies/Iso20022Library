// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance1Choice
{
    /// <summary>
    /// Opening balance for the statement period. It always equals the closing balance of the previous statement.
    /// </summary>
    [IsoId("_R9WbiNp-Ed-ak6NoX_4Aeg_-773103442")]
    [DisplayName("First")]
    public record First : OpeningBalance1Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClosingBalance1Choice
{
    /// <summary>
    /// Closing balance of this page only. This balance must be the intermediary opening balance of the next page of the same statement.
    /// </summary>
    [IsoId("_R9WbgNp-Ed-ak6NoX_4Aeg_-1862201479")]
    [DisplayName("Intermediary")]
    public record Intermediary : ClosingBalance1Choice_ { }
}

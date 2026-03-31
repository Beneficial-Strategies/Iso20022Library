// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod1Choice
{
    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_Qqpdi9p-Ed-ak6NoX_4Aeg_-1766941598")]
    [DisplayName("Statement Period")]
    public record StatementPeriod : DateAndPeriod1Choice_ { }
}

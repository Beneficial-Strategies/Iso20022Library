// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance1Choice
{
    /// <summary>
    /// Opening balance of this page only. This balance must be the intermediary closing balance of the previous page of the same statement.
    /// </summary>
    [IsoId("_R9Wbidp-Ed-ak6NoX_4Aeg_-666898093")]
    [DisplayName("Intermediary")]
    public record Intermediary : OpeningBalance1Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance5Choice
{
    /// <summary>
    /// Opening balance of this page only. This balance must be the intermediary closing balance of the previous page of the same statement.
    /// </summary>
    [IsoId("_8bhdd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Intermediary")]
    public partial record Intermediary : OpeningBalance5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Intrmy")]
        public required BalanceQuantity12Choice_ Value { get; init; }
    }
}

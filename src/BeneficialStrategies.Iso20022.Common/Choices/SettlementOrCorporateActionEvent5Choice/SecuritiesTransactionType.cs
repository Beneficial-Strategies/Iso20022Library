// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent5Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_PlajNfvmEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type")]
    public record SecuritiesTransactionType : SettlementOrCorporateActionEvent5Choice_ { }
}

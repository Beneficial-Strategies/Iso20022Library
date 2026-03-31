// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent23Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_x4idUaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Securities Transaction Type")]
    public record SecuritiesTransactionType : SettlementOrCorporateActionEvent23Choice_ { }
}

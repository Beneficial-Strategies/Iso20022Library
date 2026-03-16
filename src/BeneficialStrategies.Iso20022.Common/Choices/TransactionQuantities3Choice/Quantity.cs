// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities3Choice
{
    /// <summary>
    /// Specifies the quantity (such as securities) in the underlying transaction.
    /// </summary>
    [IsoId("_dNjxo3kcEei6JsZKrqN0hQ")]
    [DisplayName("Quantity")]
    public record Quantity : TransactionQuantities3Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionQuantities2Choice
{
    /// <summary>
    /// Specifies the quantity (such as securities) in the underlying transaction.
    /// </summary>
    [IsoId("_tqJEMlkyEeGeoaLUQk__nA_-160606030")]
    [DisplayName("Quantity")]
    public record Quantity : TransactionQuantities2Choice_ { }
}

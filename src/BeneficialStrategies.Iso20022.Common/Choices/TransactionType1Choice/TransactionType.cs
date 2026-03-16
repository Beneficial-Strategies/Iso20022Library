// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionType1Choice
{
    /// <summary>
    /// Type of investment fund transaction.
    /// </summary>
    [IsoId("_OAv0gAf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type")]
    public record TransactionType : TransactionType1Choice_ { }
}

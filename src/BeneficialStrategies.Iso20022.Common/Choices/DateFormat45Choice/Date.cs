// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat45Choice
{
    /// <summary>
    /// Date expressed as an ISO Date.
    /// </summary>
    [IsoId("_kGhRo7QYEeeKRKrD60ELBQ")]
    [DisplayName("Date")]
    public record Date : DateFormat45Choice_ { }
}

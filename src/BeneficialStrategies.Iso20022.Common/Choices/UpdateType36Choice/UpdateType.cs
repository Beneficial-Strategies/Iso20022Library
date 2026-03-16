// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType36Choice
{
    /// <summary>
    /// Request to add, modify or delete data&apos;s of a security.
    /// </summary>
    [IsoId("_QIOLUZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type")]
    public record UpdateType : UpdateType36Choice_ { }
}

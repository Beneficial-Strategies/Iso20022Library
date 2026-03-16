// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative2Choice
{
    /// <summary>
    /// Details specific for a credit derivative.
    /// </summary>
    [IsoId("_IpSbkWkwEeaLAKoEUNsD9g")]
    [DisplayName("Credit")]
    public record Credit : Derivative2Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat30Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_YCM720ECEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code")]
    public record DateCode : DateFormat30Choice_ { }
}

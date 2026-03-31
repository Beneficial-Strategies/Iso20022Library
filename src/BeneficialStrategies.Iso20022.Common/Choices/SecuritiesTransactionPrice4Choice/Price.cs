// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice4Choice
{
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_IEZAAOI_EeWWKb0jFHxViQ")]
    [DisplayName("Price")]
    public record Price : SecuritiesTransactionPrice4Choice_ { }
}

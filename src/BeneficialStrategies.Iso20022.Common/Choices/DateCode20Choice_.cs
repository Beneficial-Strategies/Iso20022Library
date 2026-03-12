// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode20Choice.Code))]
    [KnownType(typeof(DateCode20Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode20Choice.Code),nameof(DateCode20Choice.Code))]
    [JsonDerivedType(typeof(DateCode20Choice.Proprietary),nameof(DateCode20Choice.Proprietary))]
    [IsoId("_Twd1YUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code 20 Choice")]
    public abstract partial record DateCode20Choice_
    {
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode19Choice.Code))]
    [KnownType(typeof(DateCode19Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode19Choice.Code),nameof(DateCode19Choice.Code))]
    [JsonDerivedType(typeof(DateCode19Choice.Proprietary),nameof(DateCode19Choice.Proprietary))]
    [IsoId("_KEW2E0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code 19 Choice")]
    public abstract partial record DateCode19Choice_
    {
    }
}

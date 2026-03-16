// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing6Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AutomaticBorrowing6Choice.Code),
        nameof(AutomaticBorrowing6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AutomaticBorrowing6Choice.Proprietary),
        nameof(AutomaticBorrowing6Choice.Proprietary)
    )]
    [IsoId("_lL50gTtFEeWRTLSN0i0tng")]
    [DisplayName("Automatic Borrowing 6 Choice")]
    public abstract record AutomaticBorrowing6Choice_ { }
}

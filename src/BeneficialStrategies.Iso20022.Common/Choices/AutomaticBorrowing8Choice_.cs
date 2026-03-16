// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing8Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AutomaticBorrowing8Choice.Code),
        nameof(AutomaticBorrowing8Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AutomaticBorrowing8Choice.Proprietary),
        nameof(AutomaticBorrowing8Choice.Proprietary)
    )]
    [IsoId("_5m6oVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Automatic Borrowing 8 Choice")]
    public abstract record AutomaticBorrowing8Choice_ { }
}

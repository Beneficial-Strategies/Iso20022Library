// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing5Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AutomaticBorrowing5Choice.Code),
        nameof(AutomaticBorrowing5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AutomaticBorrowing5Choice.Proprietary),
        nameof(AutomaticBorrowing5Choice.Proprietary)
    )]
    [IsoId("_AY9vFNokEeC60axPepSq7g_1505904556")]
    [DisplayName("Automatic Borrowing 5 Choice")]
    public abstract record AutomaticBorrowing5Choice_ { }
}

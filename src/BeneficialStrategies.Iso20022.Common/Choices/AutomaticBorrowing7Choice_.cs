// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing7Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing7Choice.Proprietary))]
    [JsonDerivedType(typeof(AutomaticBorrowing7Choice.Code),nameof(AutomaticBorrowing7Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing7Choice.Proprietary),nameof(AutomaticBorrowing7Choice.Proprietary))]
    [IsoId("_GG1RwTt4EeW638lNyHKv7A")]
    [DisplayName("Automatic Borrowing 7 Choice")]
    public abstract partial record AutomaticBorrowing7Choice_
    {
    }
}

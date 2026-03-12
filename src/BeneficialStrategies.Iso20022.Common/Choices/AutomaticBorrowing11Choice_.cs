// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing11Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing11Choice.Proprietary))]
    [JsonDerivedType(typeof(AutomaticBorrowing11Choice.Code),nameof(AutomaticBorrowing11Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing11Choice.Proprietary),nameof(AutomaticBorrowing11Choice.Proprietary))]
    [IsoId("_6GVvS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Automatic Borrowing 11 Choice")]
    public abstract partial record AutomaticBorrowing11Choice_
    {
    }
}

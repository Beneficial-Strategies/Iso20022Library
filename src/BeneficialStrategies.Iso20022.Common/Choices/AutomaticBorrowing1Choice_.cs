// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing1Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing1Choice.Proprietary))]
    [JsonDerivedType(typeof(AutomaticBorrowing1Choice.Code),nameof(AutomaticBorrowing1Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing1Choice.Proprietary),nameof(AutomaticBorrowing1Choice.Proprietary))]
    [IsoId("_Qt7bBdp-Ed-ak6NoX_4Aeg_1870219619")]
    [DisplayName("Automatic Borrowing 1 Choice")]
    public abstract partial record AutomaticBorrowing1Choice_
    {
    }
}

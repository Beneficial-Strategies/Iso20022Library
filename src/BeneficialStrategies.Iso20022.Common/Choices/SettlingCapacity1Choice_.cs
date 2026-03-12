// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity1Choice.Code))]
    [KnownType(typeof(SettlingCapacity1Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity1Choice.Code),nameof(SettlingCapacity1Choice.Code))]
    [JsonDerivedType(typeof(SettlingCapacity1Choice.Proprietary),nameof(SettlingCapacity1Choice.Proprietary))]
    [IsoId("_QwK2stp-Ed-ak6NoX_4Aeg_-342126272")]
    [DisplayName("Settling Capacity 1 Choice")]
    public abstract partial record SettlingCapacity1Choice_
    {
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the date.
    /// </summary>
    [KnownType(typeof(DateCode1Choice.Code))]
    [KnownType(typeof(DateCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode1Choice.Code),nameof(DateCode1Choice.Code))]
    [JsonDerivedType(typeof(DateCode1Choice.Proprietary),nameof(DateCode1Choice.Proprietary))]
    [IsoId("_Quh399p-Ed-ak6NoX_4Aeg_-2023072430")]
    [DisplayName("Date Code 1 Choice")]
    public abstract partial record DateCode1Choice_
    {
    }
}

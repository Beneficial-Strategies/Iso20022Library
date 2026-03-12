// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting1Choice.Code))]
    [KnownType(typeof(Reporting1Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting1Choice.Code),nameof(Reporting1Choice.Code))]
    [JsonDerivedType(typeof(Reporting1Choice.Proprietary),nameof(Reporting1Choice.Proprietary))]
    [IsoId("_QtCDI9p-Ed-ak6NoX_4Aeg_1238156494")]
    [DisplayName("Reporting 1 Choice")]
    public abstract partial record Reporting1Choice_
    {
    }
}

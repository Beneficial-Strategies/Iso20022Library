// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle1Choice.Code))]
    [KnownType(typeof(OptionStyle1Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle1Choice.Code),nameof(OptionStyle1Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle1Choice.Proprietary),nameof(OptionStyle1Choice.Proprietary))]
    [IsoId("_Q_EOVtp-Ed-ak6NoX_4Aeg_560393555")]
    [DisplayName("Option Style 1 Choice")]
    public abstract partial record OptionStyle1Choice_
    {
    }
}

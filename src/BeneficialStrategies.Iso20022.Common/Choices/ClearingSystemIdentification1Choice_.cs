// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information used to identify a cash clearing system.
    /// </summary>
    [KnownType(typeof(ClearingSystemIdentification1Choice.ClearingSystemIdentification))]
    [KnownType(typeof(ClearingSystemIdentification1Choice.Proprietary))]
    [JsonDerivedType(typeof(ClearingSystemIdentification1Choice.ClearingSystemIdentification),nameof(ClearingSystemIdentification1Choice.ClearingSystemIdentification))]
    [JsonDerivedType(typeof(ClearingSystemIdentification1Choice.Proprietary),nameof(ClearingSystemIdentification1Choice.Proprietary))]
    [IsoId("_TMLmMNp-Ed-ak6NoX_4Aeg_-1061546408")]
    [DisplayName("Clearing System Identification 1 Choice")]
    public abstract partial record ClearingSystemIdentification1Choice_
    {
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat1Choice.Code),nameof(AdditionalBusinessProcessFormat1Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat1Choice.Proprietary),nameof(AdditionalBusinessProcessFormat1Choice.Proprietary))]
    [IsoId("_Q3dxgNp-Ed-ak6NoX_4Aeg_-250323431")]
    [DisplayName("Additional Business Process Format 1 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat1Choice_
    {
    }
}

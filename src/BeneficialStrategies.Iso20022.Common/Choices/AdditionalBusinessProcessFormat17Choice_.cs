// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat17Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat17Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat17Choice.Code),nameof(AdditionalBusinessProcessFormat17Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat17Choice.Proprietary),nameof(AdditionalBusinessProcessFormat17Choice.Proprietary))]
    [IsoId("_QR65wReoEeyroI8qKgB7Mg")]
    [DisplayName("Additional Business Process Format 17 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat17Choice_
    {
    }
}

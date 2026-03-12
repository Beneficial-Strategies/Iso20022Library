// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the missing data element.
    /// </summary>
    [KnownType(typeof(MissingData1Choice.Code))]
    [KnownType(typeof(MissingData1Choice.Proprietary))]
    [JsonDerivedType(typeof(MissingData1Choice.Code),nameof(MissingData1Choice.Code))]
    [JsonDerivedType(typeof(MissingData1Choice.Proprietary),nameof(MissingData1Choice.Proprietary))]
    [IsoId("_MN6wk9jMEeq5MfBBxQig1Q")]
    [DisplayName("Missing Data 1 Choice")]
    public abstract partial record MissingData1Choice_
    {
    }
}

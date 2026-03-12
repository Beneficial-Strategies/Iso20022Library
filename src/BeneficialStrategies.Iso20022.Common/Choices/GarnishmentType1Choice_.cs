// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of garnishment.
    /// </summary>
    [KnownType(typeof(GarnishmentType1Choice.Code))]
    [KnownType(typeof(GarnishmentType1Choice.Proprietary))]
    [JsonDerivedType(typeof(GarnishmentType1Choice.Code),nameof(GarnishmentType1Choice.Code))]
    [JsonDerivedType(typeof(GarnishmentType1Choice.Proprietary),nameof(GarnishmentType1Choice.Proprietary))]
    [IsoId("_k8MIkYnnEeOORMXOfBk1Bw")]
    [DisplayName("Garnishment Type 1 Choice")]
    public abstract partial record GarnishmentType1Choice_
    {
    }
}

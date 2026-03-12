// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed date and a recurring date.
    /// </summary>
    [KnownType(typeof(FixedOrRecurrentDate1Choice.FixedDate))]
    [KnownType(typeof(FixedOrRecurrentDate1Choice.RecurrentDate))]
    [JsonDerivedType(typeof(FixedOrRecurrentDate1Choice.FixedDate),nameof(FixedOrRecurrentDate1Choice.FixedDate))]
    [JsonDerivedType(typeof(FixedOrRecurrentDate1Choice.RecurrentDate),nameof(FixedOrRecurrentDate1Choice.RecurrentDate))]
    [IsoId("_98LLBnltEeG7BsjMvd1mEw_-980384765")]
    [DisplayName("Fixed Or Recurrent Date 1 Choice")]
    public abstract partial record FixedOrRecurrentDate1Choice_
    {
    }
}

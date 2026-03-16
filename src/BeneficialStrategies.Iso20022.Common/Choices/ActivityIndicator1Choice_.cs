// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Activity Indicator1Choice.
    /// </summary>
    [KnownType(typeof(ActivityIndicator1Choice.ISICIdentifier))]
    [KnownType(typeof(ActivityIndicator1Choice.ProprietaryIndicator))]
    [JsonDerivedType(typeof(ActivityIndicator1Choice.ISICIdentifier),nameof(ActivityIndicator1Choice.ISICIdentifier))]
    [JsonDerivedType(typeof(ActivityIndicator1Choice.ProprietaryIndicator),nameof(ActivityIndicator1Choice.ProprietaryIndicator))]
    [IsoId("_Lg8f41x7Ee6fgZt44_IqFA")]
    [DisplayName("Activity Indicator1Choice")]
    public abstract partial record ActivityIndicator1Choice_
    {
    }
}

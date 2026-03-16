// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// De minimus applicability conditions.
    /// </summary>
    [KnownType(typeof(DeMinimus1Choice.DeMinimusApplicable))]
    [KnownType(typeof(DeMinimus1Choice.DeMinimusNotApplicable))]
    [JsonDerivedType(
        typeof(DeMinimus1Choice.DeMinimusApplicable),
        nameof(DeMinimus1Choice.DeMinimusApplicable)
    )]
    [JsonDerivedType(
        typeof(DeMinimus1Choice.DeMinimusNotApplicable),
        nameof(DeMinimus1Choice.DeMinimusNotApplicable)
    )]
    [IsoId("_8saXYAgpEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus 1 Choice")]
    public abstract record DeMinimus1Choice_ { }
}

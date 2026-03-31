// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit details of one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitIdentification1Choice.Current))]
    [KnownType(typeof(LimitIdentification1Choice.Default))]
    [KnownType(typeof(LimitIdentification1Choice.AllCurrent))]
    [KnownType(typeof(LimitIdentification1Choice.AllDefault))]
    [JsonDerivedType(
        typeof(LimitIdentification1Choice.Current),
        nameof(LimitIdentification1Choice.Current)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification1Choice.Default),
        nameof(LimitIdentification1Choice.Default)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification1Choice.AllCurrent),
        nameof(LimitIdentification1Choice.AllCurrent)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification1Choice.AllDefault),
        nameof(LimitIdentification1Choice.AllDefault)
    )]
    [IsoId("_73bb56MgEeCJ6YNENx4h-w_-184786449")]
    [DisplayName("Limit Identification 1 Choice")]
    public abstract record LimitIdentification1Choice_ { }
}

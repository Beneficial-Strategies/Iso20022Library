// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit details of one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitIdentification2Choice.Current))]
    [KnownType(typeof(LimitIdentification2Choice.Default))]
    [KnownType(typeof(LimitIdentification2Choice.AllCurrent))]
    [KnownType(typeof(LimitIdentification2Choice.AllDefault))]
    [JsonDerivedType(
        typeof(LimitIdentification2Choice.Current),
        nameof(LimitIdentification2Choice.Current)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification2Choice.Default),
        nameof(LimitIdentification2Choice.Default)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification2Choice.AllCurrent),
        nameof(LimitIdentification2Choice.AllCurrent)
    )]
    [JsonDerivedType(
        typeof(LimitIdentification2Choice.AllDefault),
        nameof(LimitIdentification2Choice.AllDefault)
    )]
    [IsoId("_A_hEt24-EeiU9cctagi5ow")]
    [DisplayName("Limit Identification 2 Choice")]
    public abstract record LimitIdentification2Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status or statement that is requested.
    /// </summary>
    [KnownType(typeof(StatusOrStatement7Choice.StatusAdvice))]
    [KnownType(typeof(StatusOrStatement7Choice.Statement))]
    [JsonDerivedType(
        typeof(StatusOrStatement7Choice.StatusAdvice),
        nameof(StatusOrStatement7Choice.StatusAdvice)
    )]
    [JsonDerivedType(
        typeof(StatusOrStatement7Choice.Statement),
        nameof(StatusOrStatement7Choice.Statement)
    )]
    [IsoId("_Qrz5Jzs-EeWRTLSN0i0tng")]
    [DisplayName("Status Or Statement 7 Choice")]
    public abstract record StatusOrStatement7Choice_ { }
}

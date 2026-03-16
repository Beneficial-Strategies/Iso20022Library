// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode8Choice.Code))]
    [KnownType(typeof(PurposeCode8Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode8Choice.Code), nameof(PurposeCode8Choice.Code))]
    [JsonDerivedType(
        typeof(PurposeCode8Choice.Proprietary),
        nameof(PurposeCode8Choice.Proprietary)
    )]
    [IsoId("_5Wx6YpNLEeWGlc8L7oPDIg")]
    [DisplayName("Purpose Code 8 Choice")]
    public abstract record PurposeCode8Choice_ { }
}

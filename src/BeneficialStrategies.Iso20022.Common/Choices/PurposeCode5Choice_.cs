// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode5Choice.Code))]
    [KnownType(typeof(PurposeCode5Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode5Choice.Code), nameof(PurposeCode5Choice.Code))]
    [JsonDerivedType(
        typeof(PurposeCode5Choice.Proprietary),
        nameof(PurposeCode5Choice.Proprietary)
    )]
    [IsoId("_AeehNtokEeC60axPepSq7g_1734090960")]
    [DisplayName("Purpose Code 5 Choice")]
    public abstract record PurposeCode5Choice_ { }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a data source scheme to determine the revaluation.
    /// </summary>
    [KnownType(typeof(Revaluation2Choice.Indicator))]
    [KnownType(typeof(Revaluation2Choice.Proprietary))]
    [JsonDerivedType(typeof(Revaluation2Choice.Indicator), nameof(Revaluation2Choice.Indicator))]
    [JsonDerivedType(
        typeof(Revaluation2Choice.Proprietary),
        nameof(Revaluation2Choice.Proprietary)
    )]
    [IsoId("_AYz-ENokEeC60axPepSq7g_1301308501")]
    [DisplayName("Revaluation 2 Choice")]
    public abstract record Revaluation2Choice_ { }
}

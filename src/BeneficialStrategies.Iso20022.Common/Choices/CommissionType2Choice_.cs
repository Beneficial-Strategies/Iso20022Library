// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType2Choice.Code))]
    [KnownType(typeof(CommissionType2Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionType2Choice.Code), nameof(CommissionType2Choice.Code))]
    [JsonDerivedType(
        typeof(CommissionType2Choice.Proprietary),
        nameof(CommissionType2Choice.Proprietary)
    )]
    [IsoId("_Ac_TctokEeC60axPepSq7g_1955335824")]
    [DisplayName("Commission Type 2 Choice")]
    public abstract record CommissionType2Choice_ { }
}

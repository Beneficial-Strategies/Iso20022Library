// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the unaffirmed reason.
    /// </summary>
    [KnownType(typeof(UnaffirmedReason2Choice.Code))]
    [KnownType(typeof(UnaffirmedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(UnaffirmedReason2Choice.Code),nameof(UnaffirmedReason2Choice.Code))]
    [JsonDerivedType(typeof(UnaffirmedReason2Choice.Proprietary),nameof(UnaffirmedReason2Choice.Proprietary))]
    [IsoId("_AzfH4NokEeC60axPepSq7g_1484054937")]
    [DisplayName("Unaffirmed Reason 2 Choice")]
    public abstract partial record UnaffirmedReason2Choice_
    {
    }
}

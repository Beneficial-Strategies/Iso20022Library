// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the unaffirmed reason.
    /// </summary>
    [KnownType(typeof(UnaffirmedReason3Choice.Code))]
    [KnownType(typeof(UnaffirmedReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(UnaffirmedReason3Choice.Code),nameof(UnaffirmedReason3Choice.Code))]
    [JsonDerivedType(typeof(UnaffirmedReason3Choice.Proprietary),nameof(UnaffirmedReason3Choice.Proprietary))]
    [IsoId("_XQesQQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Unaffirmed Reason 3 Choice")]
    public abstract partial record UnaffirmedReason3Choice_
    {
    }
}

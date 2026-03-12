// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason9Choice.Code))]
    [KnownType(typeof(RejectionReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason9Choice.Code),nameof(RejectionReason9Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason9Choice.Proprietary),nameof(RejectionReason9Choice.Proprietary))]
    [IsoId("_A5wH8NokEeC60axPepSq7g_1984574511")]
    [DisplayName("Rejection Reason 9 Choice")]
    public abstract partial record RejectionReason9Choice_
    {
    }
}

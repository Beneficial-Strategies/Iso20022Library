// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(ConsentOrRejectionReason4Choice.Code))]
    [KnownType(typeof(ConsentOrRejectionReason4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConsentOrRejectionReason4Choice.Code),
        nameof(ConsentOrRejectionReason4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConsentOrRejectionReason4Choice.Proprietary),
        nameof(ConsentOrRejectionReason4Choice.Proprietary)
    )]
    [IsoId("_ne_nsTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Consent Or Rejection Reason 4 Choice")]
    public abstract record ConsentOrRejectionReason4Choice_ { }
}

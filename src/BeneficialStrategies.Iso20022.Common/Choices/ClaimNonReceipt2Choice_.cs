// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the claim non receipt is accepted or rejected.
    /// </summary>
    [KnownType(typeof(ClaimNonReceipt2Choice.Accepted))]
    [KnownType(typeof(ClaimNonReceipt2Choice.Rejected))]
    [JsonDerivedType(
        typeof(ClaimNonReceipt2Choice.Accepted),
        nameof(ClaimNonReceipt2Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(ClaimNonReceipt2Choice.Rejected),
        nameof(ClaimNonReceipt2Choice.Rejected)
    )]
    [IsoId("_EVNOIW4-EeiU9cctagi5ow")]
    [DisplayName("Claim Non Receipt 2 Choice")]
    public abstract record ClaimNonReceipt2Choice_ { }
}

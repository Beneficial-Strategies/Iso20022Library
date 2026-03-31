// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Claim Non Receipt3Choice.
    /// </summary>
    [KnownType(typeof(ClaimNonReceipt3Choice.Accepted))]
    [KnownType(typeof(ClaimNonReceipt3Choice.Rejected))]
    [JsonDerivedType(
        typeof(ClaimNonReceipt3Choice.Accepted),
        nameof(ClaimNonReceipt3Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(ClaimNonReceipt3Choice.Rejected),
        nameof(ClaimNonReceipt3Choice.Rejected)
    )]
    [IsoId("_2vK40TEyEe6g-ffJsqGiSA")]
    [DisplayName("Claim Non Receipt3Choice")]
    public abstract record ClaimNonReceipt3Choice_ { }
}

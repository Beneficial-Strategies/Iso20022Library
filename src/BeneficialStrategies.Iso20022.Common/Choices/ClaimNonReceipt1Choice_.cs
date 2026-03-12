// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the claim non receipt is accepted or rejected.
    /// </summary>
    [KnownType(typeof(ClaimNonReceipt1Choice.Accepted))]
    [KnownType(typeof(ClaimNonReceipt1Choice.Rejected))]
    [JsonDerivedType(typeof(ClaimNonReceipt1Choice.Accepted),nameof(ClaimNonReceipt1Choice.Accepted))]
    [JsonDerivedType(typeof(ClaimNonReceipt1Choice.Rejected),nameof(ClaimNonReceipt1Choice.Rejected))]
    [IsoId("_qFBVgIjYEeeDW7_wB-eK_g")]
    [DisplayName("Claim Non Receipt 1 Choice")]
    public abstract partial record ClaimNonReceipt1Choice_
    {
    }
}

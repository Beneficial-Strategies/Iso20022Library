// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the rejection reason of a claim non receipt.
    /// </summary>
    [KnownType(typeof(ClaimNonReceiptRejectReason1Choice.Code))]
    [KnownType(typeof(ClaimNonReceiptRejectReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ClaimNonReceiptRejectReason1Choice.Code),nameof(ClaimNonReceiptRejectReason1Choice.Code))]
    [JsonDerivedType(typeof(ClaimNonReceiptRejectReason1Choice.Proprietary),nameof(ClaimNonReceiptRejectReason1Choice.Proprietary))]
    [IsoId("_LafiE4tuEee-OJ-wXSj3YQ")]
    [DisplayName("Claim Non Receipt Reject Reason 1 Choice")]
    public abstract partial record ClaimNonReceiptRejectReason1Choice_
    {
    }
}

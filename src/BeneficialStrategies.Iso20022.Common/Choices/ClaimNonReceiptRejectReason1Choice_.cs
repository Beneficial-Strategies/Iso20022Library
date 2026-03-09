// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the rejection reason of a claim non receipt.
    /// </summary>
    [KnownType(typeof(ClaimNonReceiptRejectReason1Choice.Code))]
    [KnownType(typeof(ClaimNonReceiptRejectReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClaimNonReceiptRejectReason1Choice.Code),nameof(ClaimNonReceiptRejectReason1Choice.Code))]
    [JsonDerivedType(typeof(ClaimNonReceiptRejectReason1Choice.Proprietary),nameof(ClaimNonReceiptRejectReason1Choice.Proprietary))]
    #endif
    [IsoId("_LafiE4tuEee-OJ-wXSj3YQ")]
    [DisplayName("Claim Non Receipt Reject Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClaimNonReceiptRejectReason1Choice_
    #else
    public abstract partial class ClaimNonReceiptRejectReason1Choice_
    #endif
    {
    }
}

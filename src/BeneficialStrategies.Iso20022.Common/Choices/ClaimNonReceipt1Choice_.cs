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
    /// Specifies whether the claim non receipt is accepted or rejected.
    /// </summary>
    [KnownType(typeof(ClaimNonReceipt1Choice.Accepted))]
    [KnownType(typeof(ClaimNonReceipt1Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClaimNonReceipt1Choice.Accepted),nameof(ClaimNonReceipt1Choice.Accepted))]
    [JsonDerivedType(typeof(ClaimNonReceipt1Choice.Rejected),nameof(ClaimNonReceipt1Choice.Rejected))]
    #endif
    [IsoId("_qFBVgIjYEeeDW7_wB-eK_g")]
    [DisplayName("Claim Non Receipt 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClaimNonReceipt1Choice_
    #else
    public abstract partial class ClaimNonReceipt1Choice_
    #endif
    {
    }
}

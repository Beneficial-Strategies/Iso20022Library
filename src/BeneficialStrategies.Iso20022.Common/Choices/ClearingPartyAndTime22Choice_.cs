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
    /// Specifies the central counterparty intended clearing time.
    /// </summary>
    [KnownType(typeof(ClearingPartyAndTime22Choice.Reason))]
    [KnownType(typeof(ClearingPartyAndTime22Choice.Details))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClearingPartyAndTime22Choice.Reason),nameof(ClearingPartyAndTime22Choice.Reason))]
    [JsonDerivedType(typeof(ClearingPartyAndTime22Choice.Details),nameof(ClearingPartyAndTime22Choice.Details))]
    #endif
    [IsoId("_mkgZsRZOEe2QNcZTDeoKnQ")]
    [DisplayName("Clearing Party And Time 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingPartyAndTime22Choice_
    #else
    public abstract partial class ClearingPartyAndTime22Choice_
    #endif
    {
    }
}

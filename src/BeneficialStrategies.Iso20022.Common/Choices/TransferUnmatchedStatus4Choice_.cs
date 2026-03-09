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
    /// Reason for the unmatched status.
    /// </summary>
    [KnownType(typeof(TransferUnmatchedStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.Reason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.ExtendedReason))]
    [KnownType(typeof(TransferUnmatchedStatus4Choice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransferUnmatchedStatus4Choice.NoSpecifiedReason),nameof(TransferUnmatchedStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(TransferUnmatchedStatus4Choice.Reason),nameof(TransferUnmatchedStatus4Choice.Reason))]
    [JsonDerivedType(typeof(TransferUnmatchedStatus4Choice.ExtendedReason),nameof(TransferUnmatchedStatus4Choice.ExtendedReason))]
    [JsonDerivedType(typeof(TransferUnmatchedStatus4Choice.DataSourceScheme),nameof(TransferUnmatchedStatus4Choice.DataSourceScheme))]
    #endif
    [IsoId("_knN1kZM5EemKz5EOjv82iQ")]
    [DisplayName("Transfer Unmatched Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferUnmatchedStatus4Choice_
    #else
    public abstract partial class TransferUnmatchedStatus4Choice_
    #endif
    {
    }
}

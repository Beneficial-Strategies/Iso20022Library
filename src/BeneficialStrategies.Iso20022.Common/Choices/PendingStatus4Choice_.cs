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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus4Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingStatus4Choice.NoSpecifiedReason),nameof(PendingStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus4Choice.Reason),nameof(PendingStatus4Choice.Reason))]
    #endif
    [IsoId("_UYoLItp-Ed-ak6NoX_4Aeg_689331425")]
    [DisplayName("Pending Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingStatus4Choice_
    #else
    public abstract partial class PendingStatus4Choice_
    #endif
    {
    }
}

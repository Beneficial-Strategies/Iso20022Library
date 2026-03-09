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
    /// Reason for the cancelled status.
    /// </summary>
    [KnownType(typeof(CancelledStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus13Choice.Reason))]
    [KnownType(typeof(CancelledStatus13Choice.ExtendedReason))]
    [KnownType(typeof(CancelledStatus13Choice.DataSourceScheme))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CancelledStatus13Choice.NoSpecifiedReason),nameof(CancelledStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.Reason),nameof(CancelledStatus13Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.ExtendedReason),nameof(CancelledStatus13Choice.ExtendedReason))]
    [JsonDerivedType(typeof(CancelledStatus13Choice.DataSourceScheme),nameof(CancelledStatus13Choice.DataSourceScheme))]
    #endif
    [IsoId("_Pa7e0SY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Cancelled Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatus13Choice_
    #else
    public abstract partial class CancelledStatus13Choice_
    #endif
    {
    }
}

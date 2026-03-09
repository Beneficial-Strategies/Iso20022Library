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
    /// Reason for the reversed status.
    /// </summary>
    [KnownType(typeof(ReversedStatus2Choice.Reason))]
    [KnownType(typeof(ReversedStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(ReversedStatus2Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReversedStatus2Choice.Reason),nameof(ReversedStatus2Choice.Reason))]
    [JsonDerivedType(typeof(ReversedStatus2Choice.DataSourceScheme),nameof(ReversedStatus2Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(ReversedStatus2Choice.NoSpecifiedReason),nameof(ReversedStatus2Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_a4QdwSY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Reversed Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReversedStatus2Choice_
    #else
    public abstract partial class ReversedStatus2Choice_
    #endif
    {
    }
}

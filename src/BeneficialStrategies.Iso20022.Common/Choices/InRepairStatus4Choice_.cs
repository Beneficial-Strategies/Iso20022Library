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
    /// Reason for the in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatus4Choice.Reason))]
    [KnownType(typeof(InRepairStatus4Choice.DataSourceScheme))]
    [KnownType(typeof(InRepairStatus4Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InRepairStatus4Choice.Reason),nameof(InRepairStatus4Choice.Reason))]
    [JsonDerivedType(typeof(InRepairStatus4Choice.DataSourceScheme),nameof(InRepairStatus4Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(InRepairStatus4Choice.NoSpecifiedReason),nameof(InRepairStatus4Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_xydlISY4EeW_ZNn8gbfY7Q")]
    [DisplayName("In Repair Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InRepairStatus4Choice_
    #else
    public abstract partial class InRepairStatus4Choice_
    #endif
    {
    }
}

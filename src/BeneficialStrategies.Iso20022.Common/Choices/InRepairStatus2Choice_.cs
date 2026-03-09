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
    /// Status is in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatus2Choice.Reason))]
    [KnownType(typeof(InRepairStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(InRepairStatus2Choice.NoReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InRepairStatus2Choice.Reason),nameof(InRepairStatus2Choice.Reason))]
    [JsonDerivedType(typeof(InRepairStatus2Choice.DataSourceScheme),nameof(InRepairStatus2Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(InRepairStatus2Choice.NoReason),nameof(InRepairStatus2Choice.NoReason))]
    #endif
    [IsoId("_Ut7sw9p-Ed-ak6NoX_4Aeg_1209831278")]
    [DisplayName("In Repair Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InRepairStatus2Choice_
    #else
    public abstract partial class InRepairStatus2Choice_
    #endif
    {
    }
}

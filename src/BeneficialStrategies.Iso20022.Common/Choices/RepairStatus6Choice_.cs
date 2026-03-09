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
    [KnownType(typeof(RepairStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus6Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepairStatus6Choice.NoSpecifiedReason),nameof(RepairStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RepairStatus6Choice.Reason),nameof(RepairStatus6Choice.Reason))]
    #endif
    [IsoId("_Vn3Okf7rEeCvPoRGOxRobQ")]
    [DisplayName("Repair Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairStatus6Choice_
    #else
    public abstract partial class RepairStatus6Choice_
    #endif
    {
    }
}

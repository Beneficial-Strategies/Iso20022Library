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
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus2Choice.Pending))]
    [KnownType(typeof(SettlementStatus2Choice.Failing))]
    [KnownType(typeof(SettlementStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus2Choice.Pending),nameof(SettlementStatus2Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus2Choice.Failing),nameof(SettlementStatus2Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus2Choice.Proprietary),nameof(SettlementStatus2Choice.Proprietary))]
    #endif
    [IsoId("_UZ9n4dp-Ed-ak6NoX_4Aeg_-647907102")]
    [DisplayName("Settlement Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus2Choice_
    #else
    public abstract partial class SettlementStatus2Choice_
    #endif
    {
    }
}

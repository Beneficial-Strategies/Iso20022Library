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
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties36Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties36Choice.ReceivingSettlementParties))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementParties36Choice.DeliveringSettlementParties),nameof(SettlementParties36Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties36Choice.ReceivingSettlementParties),nameof(SettlementParties36Choice.ReceivingSettlementParties))]
    #endif
    [IsoId("_Vx2Q9yqSEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Parties 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties36Choice_
    #else
    public abstract partial class SettlementParties36Choice_
    #endif
    {
    }
}

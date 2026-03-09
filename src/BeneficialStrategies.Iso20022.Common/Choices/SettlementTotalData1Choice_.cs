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
    /// Specifies the aggregated data of settlement instructions or explicit no data report.
    /// </summary>
    [KnownType(typeof(SettlementTotalData1Choice.DataSetAction))]
    [KnownType(typeof(SettlementTotalData1Choice.Data))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementTotalData1Choice.DataSetAction),nameof(SettlementTotalData1Choice.DataSetAction))]
    [JsonDerivedType(typeof(SettlementTotalData1Choice.Data),nameof(SettlementTotalData1Choice.Data))]
    #endif
    [IsoId("_allUdx2lEeqF2P5v-Rtejg")]
    [DisplayName("Settlement Total Data 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementTotalData1Choice_
    #else
    public abstract partial class SettlementTotalData1Choice_
    #endif
    {
    }
}

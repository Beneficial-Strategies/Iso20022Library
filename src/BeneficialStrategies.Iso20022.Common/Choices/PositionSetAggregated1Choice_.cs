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
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(PositionSetAggregated1Choice.DataSetAction))]
    [KnownType(typeof(PositionSetAggregated1Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PositionSetAggregated1Choice.DataSetAction),nameof(PositionSetAggregated1Choice.DataSetAction))]
    [JsonDerivedType(typeof(PositionSetAggregated1Choice.Report),nameof(PositionSetAggregated1Choice.Report))]
    #endif
    [IsoId("_CHENw0whEeqwfMIOLcNxbw")]
    [DisplayName("Position Set Aggregated 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PositionSetAggregated1Choice_
    #else
    public abstract partial class PositionSetAggregated1Choice_
    #endif
    {
    }
}

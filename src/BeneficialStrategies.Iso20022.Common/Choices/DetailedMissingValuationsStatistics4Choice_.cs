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
    /// Detailed information of no valuation or outdated valuation.
    /// </summary>
    [KnownType(typeof(DetailedMissingValuationsStatistics4Choice.DataSetAction))]
    [KnownType(typeof(DetailedMissingValuationsStatistics4Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DetailedMissingValuationsStatistics4Choice.DataSetAction),nameof(DetailedMissingValuationsStatistics4Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedMissingValuationsStatistics4Choice.Report),nameof(DetailedMissingValuationsStatistics4Choice.Report))]
    #endif
    [IsoId("_x0O2MVyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Missing Valuations Statistics 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DetailedMissingValuationsStatistics4Choice_
    #else
    public abstract partial class DetailedMissingValuationsStatistics4Choice_
    #endif
    {
    }
}

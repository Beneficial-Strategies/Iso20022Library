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
    /// Information about number of transactions accepted and rejected and the reasons of the rejections.
    /// </summary>
    [KnownType(typeof(DetailedTransactionStatistics6Choice.DataSetAction))]
    [KnownType(typeof(DetailedTransactionStatistics6Choice.DetailedStatistics))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DetailedTransactionStatistics6Choice.DataSetAction),nameof(DetailedTransactionStatistics6Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedTransactionStatistics6Choice.DetailedStatistics),nameof(DetailedTransactionStatistics6Choice.DetailedStatistics))]
    #endif
    [IsoId("_x-ovZ1yGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Transaction Statistics 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DetailedTransactionStatistics6Choice_
    #else
    public abstract partial class DetailedTransactionStatistics6Choice_
    #endif
    {
    }
}

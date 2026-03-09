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
    [KnownType(typeof(DetailedTransactionStatistics2Choice.DataSetAction))]
    [KnownType(typeof(DetailedTransactionStatistics2Choice.DetailedStatistics))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DetailedTransactionStatistics2Choice.DataSetAction),nameof(DetailedTransactionStatistics2Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedTransactionStatistics2Choice.DetailedStatistics),nameof(DetailedTransactionStatistics2Choice.DetailedStatistics))]
    #endif
    [IsoId("_hTXSB8K4EeuFNp8LZAnorg")]
    [DisplayName("Detailed Transaction Statistics 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DetailedTransactionStatistics2Choice_
    #else
    public abstract partial class DetailedTransactionStatistics2Choice_
    #endif
    {
    }
}

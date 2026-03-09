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
    /// Choice between profit and loss.
    /// </summary>
    [KnownType(typeof(ProfitAndLoss2Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss2Choice.Loss))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProfitAndLoss2Choice.Profit),nameof(ProfitAndLoss2Choice.Profit))]
    [JsonDerivedType(typeof(ProfitAndLoss2Choice.Loss),nameof(ProfitAndLoss2Choice.Loss))]
    #endif
    [IsoId("_NDhRoWYDEeaJx-BUPcSWQA")]
    [DisplayName("Profit And Loss 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProfitAndLoss2Choice_
    #else
    public abstract partial class ProfitAndLoss2Choice_
    #endif
    {
    }
}

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
    [KnownType(typeof(ProfitAndLoss1Choice.Profit))]
    [KnownType(typeof(ProfitAndLoss1Choice.Loss))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProfitAndLoss1Choice.Profit),nameof(ProfitAndLoss1Choice.Profit))]
    [JsonDerivedType(typeof(ProfitAndLoss1Choice.Loss),nameof(ProfitAndLoss1Choice.Loss))]
    #endif
    [IsoId("_Q65gCNp-Ed-ak6NoX_4Aeg_-931034423")]
    [DisplayName("Profit And Loss 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProfitAndLoss1Choice_
    #else
    public abstract partial class ProfitAndLoss1Choice_
    #endif
    {
    }
}

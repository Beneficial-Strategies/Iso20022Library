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
    /// Choice of balance types to provide transaction details.
    /// </summary>
    [KnownType(typeof(AdjustedBalanceTypeSD2Choice.StockLoan))]
    [KnownType(typeof(AdjustedBalanceTypeSD2Choice.Repo))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD2Choice.StockLoan),nameof(AdjustedBalanceTypeSD2Choice.StockLoan))]
    [JsonDerivedType(typeof(AdjustedBalanceTypeSD2Choice.Repo),nameof(AdjustedBalanceTypeSD2Choice.Repo))]
    #endif
    [IsoId("_vSOqAUk9EeK8UrXTVVBVxw")]
    [DisplayName("Adjusted Balance Type SD 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdjustedBalanceTypeSD2Choice_
    #else
    public abstract partial class AdjustedBalanceTypeSD2Choice_
    #endif
    {
    }
}

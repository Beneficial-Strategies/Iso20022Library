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
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat2Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat2Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat2Choice.Rate),nameof(RateAndAmountFormat2Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat2Choice.Amount),nameof(RateAndAmountFormat2Choice.Amount))]
    #endif
    [IsoId("_UPYvldp-Ed-ak6NoX_4Aeg_-1644730391")]
    [DisplayName("Rate And Amount Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat2Choice_
    #else
    public abstract partial class RateAndAmountFormat2Choice_
    #endif
    {
    }
}

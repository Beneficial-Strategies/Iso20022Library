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
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRate1Choice.NotSpecifiedRate))]
    [KnownType(typeof(GrossDividendRate1Choice.Amount))]
    [KnownType(typeof(GrossDividendRate1Choice.RateTypeAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GrossDividendRate1Choice.NotSpecifiedRate),nameof(GrossDividendRate1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRate1Choice.Amount),nameof(GrossDividendRate1Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRate1Choice.RateTypeAmount),nameof(GrossDividendRate1Choice.RateTypeAmount))]
    #endif
    [IsoId("_UPO-mdp-Ed-ak6NoX_4Aeg_1360546700")]
    [DisplayName("Gross Dividend Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRate1Choice_
    #else
    public abstract partial class GrossDividendRate1Choice_
    #endif
    {
    }
}

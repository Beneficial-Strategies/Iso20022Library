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
    /// Choice of format for the securities RTGS information.
    /// </summary>
    [KnownType(typeof(SecuritiesRTGS1Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesRTGS1Choice.Indicator),nameof(SecuritiesRTGS1Choice.Indicator))]
    [JsonDerivedType(typeof(SecuritiesRTGS1Choice.Proprietary),nameof(SecuritiesRTGS1Choice.Proprietary))]
    #endif
    [IsoId("_QwBFt9p-Ed-ak6NoX_4Aeg_-613904769")]
    [DisplayName("Securities RTGS 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesRTGS1Choice_
    #else
    public abstract partial class SecuritiesRTGS1Choice_
    #endif
    {
    }
}

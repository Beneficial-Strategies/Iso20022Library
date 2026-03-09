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
    [KnownType(typeof(SecuritiesRTGS4Choice.Indicator))]
    [KnownType(typeof(SecuritiesRTGS4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesRTGS4Choice.Indicator),nameof(SecuritiesRTGS4Choice.Indicator))]
    [JsonDerivedType(typeof(SecuritiesRTGS4Choice.Proprietary),nameof(SecuritiesRTGS4Choice.Proprietary))]
    #endif
    [IsoId("_90cwnzqEEeWVrPy0StzzSg")]
    [DisplayName("Securities RTGS 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesRTGS4Choice_
    #else
    public abstract partial class SecuritiesRTGS4Choice_
    #endif
    {
    }
}

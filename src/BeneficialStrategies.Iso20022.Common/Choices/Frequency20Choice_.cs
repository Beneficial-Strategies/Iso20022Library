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
    /// Choice of formats for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency20Choice.Code))]
    [KnownType(typeof(Frequency20Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Frequency20Choice.Code),nameof(Frequency20Choice.Code))]
    [JsonDerivedType(typeof(Frequency20Choice.Proprietary),nameof(Frequency20Choice.Proprietary))]
    #endif
    [IsoId("_B_wykRUSEeOIaq8KyCdIDQ")]
    [DisplayName("Frequency 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Frequency20Choice_
    #else
    public abstract partial class Frequency20Choice_
    #endif
    {
    }
}

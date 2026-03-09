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
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking3Choice.Indicator))]
    [KnownType(typeof(Tracking3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Tracking3Choice.Indicator),nameof(Tracking3Choice.Indicator))]
    [JsonDerivedType(typeof(Tracking3Choice.Proprietary),nameof(Tracking3Choice.Proprietary))]
    #endif
    [IsoId("_AZHgEdokEeC60axPepSq7g_546870439")]
    [DisplayName("Tracking 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Tracking3Choice_
    #else
    public abstract partial class Tracking3Choice_
    #endif
    {
    }
}

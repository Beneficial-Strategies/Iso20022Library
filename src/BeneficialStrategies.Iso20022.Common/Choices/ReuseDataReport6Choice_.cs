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
    /// Information on reusability of previously submitted data.
    /// </summary>
    [KnownType(typeof(ReuseDataReport6Choice.New))]
    [KnownType(typeof(ReuseDataReport6Choice.Error))]
    [KnownType(typeof(ReuseDataReport6Choice.Correction))]
    [KnownType(typeof(ReuseDataReport6Choice.CollateralReuseUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReuseDataReport6Choice.New),nameof(ReuseDataReport6Choice.New))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.Error),nameof(ReuseDataReport6Choice.Error))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.Correction),nameof(ReuseDataReport6Choice.Correction))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.CollateralReuseUpdate),nameof(ReuseDataReport6Choice.CollateralReuseUpdate))]
    #endif
    [IsoId("_MxqLscK8EeuMhqg3CsEu6Q")]
    [DisplayName("Reuse Data Report 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReuseDataReport6Choice_
    #else
    public abstract partial class ReuseDataReport6Choice_
    #endif
    {
    }
}

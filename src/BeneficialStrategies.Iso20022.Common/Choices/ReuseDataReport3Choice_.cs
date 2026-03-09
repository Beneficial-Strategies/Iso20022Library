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
    [KnownType(typeof(ReuseDataReport3Choice.New))]
    [KnownType(typeof(ReuseDataReport3Choice.Error))]
    [KnownType(typeof(ReuseDataReport3Choice.Correction))]
    [KnownType(typeof(ReuseDataReport3Choice.CollateralReuseUpdate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReuseDataReport3Choice.New),nameof(ReuseDataReport3Choice.New))]
    [JsonDerivedType(typeof(ReuseDataReport3Choice.Error),nameof(ReuseDataReport3Choice.Error))]
    [JsonDerivedType(typeof(ReuseDataReport3Choice.Correction),nameof(ReuseDataReport3Choice.Correction))]
    [JsonDerivedType(typeof(ReuseDataReport3Choice.CollateralReuseUpdate),nameof(ReuseDataReport3Choice.CollateralReuseUpdate))]
    #endif
    [IsoId("_0hwiga4bEemB_csI4yyKLA")]
    [DisplayName("Reuse Data Report 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReuseDataReport3Choice_
    #else
    public abstract partial class ReuseDataReport3Choice_
    #endif
    {
    }
}

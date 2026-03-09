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
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType32Choice.Code))]
    [KnownType(typeof(FractionDispositionType32Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FractionDispositionType32Choice.Code),nameof(FractionDispositionType32Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType32Choice.Proprietary),nameof(FractionDispositionType32Choice.Proprietary))]
    #endif
    [IsoId("_c5Lh-5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType32Choice_
    #else
    public abstract partial class FractionDispositionType32Choice_
    #endif
    {
    }
}

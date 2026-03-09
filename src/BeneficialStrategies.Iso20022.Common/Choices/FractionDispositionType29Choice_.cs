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
    [KnownType(typeof(FractionDispositionType29Choice.Code))]
    [KnownType(typeof(FractionDispositionType29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FractionDispositionType29Choice.Code),nameof(FractionDispositionType29Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType29Choice.Proprietary),nameof(FractionDispositionType29Choice.Proprietary))]
    #endif
    [IsoId("_chdmX5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType29Choice_
    #else
    public abstract partial class FractionDispositionType29Choice_
    #endif
    {
    }
}

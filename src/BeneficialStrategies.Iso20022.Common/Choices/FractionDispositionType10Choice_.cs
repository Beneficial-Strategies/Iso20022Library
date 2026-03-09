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
    [KnownType(typeof(FractionDispositionType10Choice.Code))]
    [KnownType(typeof(FractionDispositionType10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FractionDispositionType10Choice.Code),nameof(FractionDispositionType10Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType10Choice.Proprietary),nameof(FractionDispositionType10Choice.Proprietary))]
    #endif
    [IsoId("_XZY5UeHEEd-1Ktb5rVaajw")]
    [DisplayName("Fraction Disposition Type 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType10Choice_
    #else
    public abstract partial class FractionDispositionType10Choice_
    #endif
    {
    }
}

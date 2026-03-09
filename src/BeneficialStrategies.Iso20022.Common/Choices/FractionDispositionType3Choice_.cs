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
    [KnownType(typeof(FractionDispositionType3Choice.Code))]
    [KnownType(typeof(FractionDispositionType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FractionDispositionType3Choice.Code),nameof(FractionDispositionType3Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType3Choice.Proprietary),nameof(FractionDispositionType3Choice.Proprietary))]
    #endif
    [IsoId("_QzJSMNp-Ed-ak6NoX_4Aeg_1234427512")]
    [DisplayName("Fraction Disposition Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType3Choice_
    #else
    public abstract partial class FractionDispositionType3Choice_
    #endif
    {
    }
}

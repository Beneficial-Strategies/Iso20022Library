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
    [KnownType(typeof(FractionDispositionType17Choice.Code))]
    [KnownType(typeof(FractionDispositionType17Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FractionDispositionType17Choice.Code),nameof(FractionDispositionType17Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType17Choice.Proprietary),nameof(FractionDispositionType17Choice.Proprietary))]
    #endif
    [IsoId("_ootVsWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition Type 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType17Choice_
    #else
    public abstract partial class FractionDispositionType17Choice_
    #endif
    {
    }
}

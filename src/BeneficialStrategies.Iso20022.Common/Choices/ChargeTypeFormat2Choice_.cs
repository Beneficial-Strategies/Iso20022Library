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
    /// Type of charge expressed either in free format or in structured or free form.
    /// </summary>
    [KnownType(typeof(ChargeTypeFormat2Choice.Unstructured))]
    [KnownType(typeof(ChargeTypeFormat2Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeTypeFormat2Choice.Unstructured),nameof(ChargeTypeFormat2Choice.Unstructured))]
    [JsonDerivedType(typeof(ChargeTypeFormat2Choice.Structured),nameof(ChargeTypeFormat2Choice.Structured))]
    #endif
    [IsoId("_UyQMF9p-Ed-ak6NoX_4Aeg_1822769667")]
    [DisplayName("Charge Type Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTypeFormat2Choice_
    #else
    public abstract partial class ChargeTypeFormat2Choice_
    #endif
    {
    }
}

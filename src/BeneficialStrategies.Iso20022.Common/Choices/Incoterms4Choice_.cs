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
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [KnownType(typeof(Incoterms4Choice.Code))]
    [KnownType(typeof(Incoterms4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Incoterms4Choice.Code),nameof(Incoterms4Choice.Code))]
    [JsonDerivedType(typeof(Incoterms4Choice.Proprietary),nameof(Incoterms4Choice.Proprietary))]
    #endif
    [IsoId("_S5ezYAEcEeCQm6a_G2yO_w_-552526097")]
    [DisplayName("Incoterms 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Incoterms4Choice_
    #else
    public abstract partial class Incoterms4Choice_
    #endif
    {
    }
}

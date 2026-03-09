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
    /// Choice between a standard code or a proprietary code for specifying the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeTypeFormat3Choice.Code))]
    [KnownType(typeof(ChargeTypeFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeTypeFormat3Choice.Code),nameof(ChargeTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(ChargeTypeFormat3Choice.Proprietary),nameof(ChargeTypeFormat3Choice.Proprietary))]
    #endif
    [IsoId("_SumZGAEcEeCQm6a_G2yO_w_-323624829")]
    [DisplayName("Charge Type Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeTypeFormat3Choice_
    #else
    public abstract partial class ChargeTypeFormat3Choice_
    #endif
    {
    }
}

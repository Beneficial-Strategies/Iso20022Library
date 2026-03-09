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
    /// Choice of formats for the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType5Choice.Code))]
    [KnownType(typeof(ChargeType5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType5Choice.Code),nameof(ChargeType5Choice.Code))]
    [JsonDerivedType(typeof(ChargeType5Choice.Proprietary),nameof(ChargeType5Choice.Proprietary))]
    #endif
    [IsoId("_KJb5gDh5EeaH-93K5JKmzw")]
    [DisplayName("Charge Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType5Choice_
    #else
    public abstract partial class ChargeType5Choice_
    #endif
    {
    }
}

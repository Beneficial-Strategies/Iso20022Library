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
    /// Choice of formats for the charge or commission basis.
    /// </summary>
    [KnownType(typeof(ChargeBasis2Choice.Code))]
    [KnownType(typeof(ChargeBasis2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeBasis2Choice.Code),nameof(ChargeBasis2Choice.Code))]
    [JsonDerivedType(typeof(ChargeBasis2Choice.Proprietary),nameof(ChargeBasis2Choice.Proprietary))]
    #endif
    [IsoId("_1qZNADh5EeaH-93K5JKmzw")]
    [DisplayName("Charge Basis 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeBasis2Choice_
    #else
    public abstract partial class ChargeBasis2Choice_
    #endif
    {
    }
}

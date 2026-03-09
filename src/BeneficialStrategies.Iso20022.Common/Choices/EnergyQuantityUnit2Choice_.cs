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
    /// Specifies the units used to quantify an energy.
    /// </summary>
    [KnownType(typeof(EnergyQuantityUnit2Choice.Code))]
    [KnownType(typeof(EnergyQuantityUnit2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EnergyQuantityUnit2Choice.Code),nameof(EnergyQuantityUnit2Choice.Code))]
    [JsonDerivedType(typeof(EnergyQuantityUnit2Choice.Proprietary),nameof(EnergyQuantityUnit2Choice.Proprietary))]
    #endif
    [IsoId("_r9qqoSi_EeuKKc2MztSwPw")]
    [DisplayName("Energy Quantity Unit 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EnergyQuantityUnit2Choice_
    #else
    public abstract partial class EnergyQuantityUnit2Choice_
    #endif
    {
    }
}

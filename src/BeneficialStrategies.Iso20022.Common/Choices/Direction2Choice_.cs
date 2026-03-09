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
    /// Choice between elements indicating the direction of the derivative transaction.
    /// </summary>
    [KnownType(typeof(Direction2Choice.DirectionOfTheFirstLeg))]
    [KnownType(typeof(Direction2Choice.CounterpartySide))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Direction2Choice.DirectionOfTheFirstLeg),nameof(Direction2Choice.DirectionOfTheFirstLeg))]
    [JsonDerivedType(typeof(Direction2Choice.CounterpartySide),nameof(Direction2Choice.CounterpartySide))]
    #endif
    [IsoId("_n79FOXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Direction2Choice_
    #else
    public abstract partial class Direction2Choice_
    #endif
    {
    }
}

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
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(ReservationType2Choice.Code))]
    [KnownType(typeof(ReservationType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationType2Choice.Code),nameof(ReservationType2Choice.Code))]
    [JsonDerivedType(typeof(ReservationType2Choice.Proprietary),nameof(ReservationType2Choice.Proprietary))]
    #endif
    [IsoId("_5v7SsRUNEeusI4XK3oQSyg")]
    [DisplayName("Reservation Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationType2Choice_
    #else
    public abstract partial class ReservationType2Choice_
    #endif
    {
    }
}

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
    /// Reports either on the reservation or on a business error.
    /// </summary>
    [KnownType(typeof(ReservationOrError9Choice.Reservation))]
    [KnownType(typeof(ReservationOrError9Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationOrError9Choice.Reservation),nameof(ReservationOrError9Choice.Reservation))]
    [JsonDerivedType(typeof(ReservationOrError9Choice.BusinessError),nameof(ReservationOrError9Choice.BusinessError))]
    #endif
    [IsoId("_RN8LwXhdEeidzqjNEfehPg")]
    [DisplayName("Reservation Or Error 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationOrError9Choice_
    #else
    public abstract partial class ReservationOrError9Choice_
    #endif
    {
    }
}

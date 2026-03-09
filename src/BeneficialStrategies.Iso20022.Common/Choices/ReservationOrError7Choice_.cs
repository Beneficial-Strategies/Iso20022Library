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
    [KnownType(typeof(ReservationOrError7Choice.Reservation))]
    [KnownType(typeof(ReservationOrError7Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationOrError7Choice.Reservation),nameof(ReservationOrError7Choice.Reservation))]
    [JsonDerivedType(typeof(ReservationOrError7Choice.BusinessError),nameof(ReservationOrError7Choice.BusinessError))]
    #endif
    [IsoId("_T0LEt5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Or Error 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationOrError7Choice_
    #else
    public abstract partial class ReservationOrError7Choice_
    #endif
    {
    }
}

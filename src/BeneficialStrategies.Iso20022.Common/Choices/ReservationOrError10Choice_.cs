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
    /// It is used to provide confirmation details of one or more reservations set by the member (or on behalf of the member) and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ReservationOrError10Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError10Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationOrError10Choice.BusinessReport),nameof(ReservationOrError10Choice.BusinessReport))]
    [JsonDerivedType(typeof(ReservationOrError10Choice.OperationalError),nameof(ReservationOrError10Choice.OperationalError))]
    #endif
    [IsoId("_eGwpEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Or Error 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationOrError10Choice_
    #else
    public abstract partial class ReservationOrError10Choice_
    #endif
    {
    }
}

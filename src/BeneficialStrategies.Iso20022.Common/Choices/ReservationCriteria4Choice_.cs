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
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria4Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria4Choice.NewCriteria))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationCriteria4Choice.QueryName),nameof(ReservationCriteria4Choice.QueryName))]
    [JsonDerivedType(typeof(ReservationCriteria4Choice.NewCriteria),nameof(ReservationCriteria4Choice.NewCriteria))]
    #endif
    [IsoId("_grsrAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Criteria 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationCriteria4Choice_
    #else
    public abstract partial class ReservationCriteria4Choice_
    #endif
    {
    }
}

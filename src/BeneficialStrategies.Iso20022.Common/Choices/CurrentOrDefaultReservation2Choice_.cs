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
    /// Current or default reservation set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation2Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation2Choice.Default))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CurrentOrDefaultReservation2Choice.Current),nameof(CurrentOrDefaultReservation2Choice.Current))]
    [JsonDerivedType(typeof(CurrentOrDefaultReservation2Choice.Default),nameof(CurrentOrDefaultReservation2Choice.Default))]
    #endif
    [IsoId("_BndOfW4-EeiU9cctagi5ow")]
    [DisplayName("Current Or Default Reservation 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrentOrDefaultReservation2Choice_
    #else
    public abstract partial class CurrentOrDefaultReservation2Choice_
    #endif
    {
    }
}

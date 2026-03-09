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
    /// Choice between a code or a data source scheme to determine the booking unit.
    /// </summary>
    [KnownType(typeof(BookingUnit1Choice.Code))]
    [KnownType(typeof(BookingUnit1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BookingUnit1Choice.Code),nameof(BookingUnit1Choice.Code))]
    [JsonDerivedType(typeof(BookingUnit1Choice.Proprietary),nameof(BookingUnit1Choice.Proprietary))]
    #endif
    [IsoId("_Q-6dVtp-Ed-ak6NoX_4Aeg_1716011738")]
    [DisplayName("Booking Unit 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BookingUnit1Choice_
    #else
    public abstract partial class BookingUnit1Choice_
    #endif
    {
    }
}

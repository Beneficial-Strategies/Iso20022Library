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
    [KnownType(typeof(ReservationType1Choice.Code))]
    [KnownType(typeof(ReservationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReservationType1Choice.Code),nameof(ReservationType1Choice.Code))]
    [JsonDerivedType(typeof(ReservationType1Choice.Proprietary),nameof(ReservationType1Choice.Proprietary))]
    #endif
    [IsoId("_8JKFEKMgEeCJ6YNENx4h-w_632867546")]
    [DisplayName("Reservation Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReservationType1Choice_
    #else
    public abstract partial class ReservationType1Choice_
    #endif
    {
    }
}

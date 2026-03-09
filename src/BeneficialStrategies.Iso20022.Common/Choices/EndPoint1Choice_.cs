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
    /// Choice of either the last payment date or the number of payments to make. 
    /// </summary>
    [KnownType(typeof(EndPoint1Choice.NumberOfPayments))]
    [KnownType(typeof(EndPoint1Choice.LastPaymentDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EndPoint1Choice.NumberOfPayments),nameof(EndPoint1Choice.NumberOfPayments))]
    [JsonDerivedType(typeof(EndPoint1Choice.LastPaymentDate),nameof(EndPoint1Choice.LastPaymentDate))]
    #endif
    [IsoId("__b7DoQ2lEeSNWNtJlXOAhg")]
    [DisplayName("End Point 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EndPoint1Choice_
    #else
    public abstract partial class EndPoint1Choice_
    #endif
    {
    }
}

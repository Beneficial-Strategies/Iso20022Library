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
    /// Choice between a status quantity or a quantity to receive for the quantity of financial instrument.
    /// </summary>
    [KnownType(typeof(StatusOrQuantityToReceive1Choice.StatusQuantity))]
    [KnownType(typeof(StatusOrQuantityToReceive1Choice.QuantityToReceive))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatusOrQuantityToReceive1Choice.StatusQuantity),nameof(StatusOrQuantityToReceive1Choice.StatusQuantity))]
    [JsonDerivedType(typeof(StatusOrQuantityToReceive1Choice.QuantityToReceive),nameof(StatusOrQuantityToReceive1Choice.QuantityToReceive))]
    #endif
    [IsoId("_UGl_-tp-Ed-ak6NoX_4Aeg_1067930232")]
    [DisplayName("Status Or Quantity To Receive 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatusOrQuantityToReceive1Choice_
    #else
    public abstract partial class StatusOrQuantityToReceive1Choice_
    #endif
    {
    }
}

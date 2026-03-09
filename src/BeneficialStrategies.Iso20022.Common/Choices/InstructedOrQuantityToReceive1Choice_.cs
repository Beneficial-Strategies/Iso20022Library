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
    /// Choice between an instructed quantity or a quantity to receive.
    /// </summary>
    [KnownType(typeof(InstructedOrQuantityToReceive1Choice.InstructedQuantity))]
    [KnownType(typeof(InstructedOrQuantityToReceive1Choice.QuantityToReceive))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructedOrQuantityToReceive1Choice.InstructedQuantity),nameof(InstructedOrQuantityToReceive1Choice.InstructedQuantity))]
    [JsonDerivedType(typeof(InstructedOrQuantityToReceive1Choice.QuantityToReceive),nameof(InstructedOrQuantityToReceive1Choice.QuantityToReceive))]
    #endif
    [IsoId("_UHCr6dp-Ed-ak6NoX_4Aeg_-1969996831")]
    [DisplayName("Instructed Or Quantity To Receive 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructedOrQuantityToReceive1Choice_
    #else
    public abstract partial class InstructedOrQuantityToReceive1Choice_
    #endif
    {
    }
}

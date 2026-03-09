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
    /// Choice between a quantity expressed in units, face amount or amortised amount and a quantity expressed as an amount.
    /// </summary>
    [KnownType(typeof(QuantityOrAmount2Choice.Quantity))]
    [KnownType(typeof(QuantityOrAmount2Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(QuantityOrAmount2Choice.Quantity),nameof(QuantityOrAmount2Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityOrAmount2Choice.Amount),nameof(QuantityOrAmount2Choice.Amount))]
    #endif
    [IsoId("_wFZWYQeCEe2fOITqoTnSLQ")]
    [DisplayName("Quantity Or Amount 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuantityOrAmount2Choice_
    #else
    public abstract partial class QuantityOrAmount2Choice_
    #endif
    {
    }
}

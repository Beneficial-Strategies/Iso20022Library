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
    /// Choice between securities quantities or an amount.
    /// </summary>
    [KnownType(typeof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount7Choice.InstructedAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity),nameof(SecuritiesQuantityOrAmount7Choice.SecuritiesQuantity))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount7Choice.InstructedAmount),nameof(SecuritiesQuantityOrAmount7Choice.InstructedAmount))]
    #endif
    [IsoId("_pizbXzi7Eeydid5dcNPKvg")]
    [DisplayName("Securities Quantity Or Amount 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesQuantityOrAmount7Choice_
    #else
    public abstract partial class SecuritiesQuantityOrAmount7Choice_
    #endif
    {
    }
}

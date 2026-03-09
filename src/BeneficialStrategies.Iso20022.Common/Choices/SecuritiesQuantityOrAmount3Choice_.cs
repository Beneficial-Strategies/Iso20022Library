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
    [KnownType(typeof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount3Choice.InstructedAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity),nameof(SecuritiesQuantityOrAmount3Choice.SecuritiesQuantity))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount3Choice.InstructedAmount),nameof(SecuritiesQuantityOrAmount3Choice.InstructedAmount))]
    #endif
    [IsoId("_nRxjkdNPEee-r40DhxXRmg")]
    [DisplayName("Securities Quantity Or Amount 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesQuantityOrAmount3Choice_
    #else
    public abstract partial class SecuritiesQuantityOrAmount3Choice_
    #endif
    {
    }
}

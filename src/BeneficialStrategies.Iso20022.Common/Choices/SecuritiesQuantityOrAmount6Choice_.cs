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
    [KnownType(typeof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity))]
    [KnownType(typeof(SecuritiesQuantityOrAmount6Choice.InstructedAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity),nameof(SecuritiesQuantityOrAmount6Choice.SecuritiesQuantity))]
    [JsonDerivedType(typeof(SecuritiesQuantityOrAmount6Choice.InstructedAmount),nameof(SecuritiesQuantityOrAmount6Choice.InstructedAmount))]
    #endif
    [IsoId("_Np2b7RuyEeyhRdHRjakS2w")]
    [DisplayName("Securities Quantity Or Amount 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesQuantityOrAmount6Choice_
    #else
    public abstract partial class SecuritiesQuantityOrAmount6Choice_
    #endif
    {
    }
}

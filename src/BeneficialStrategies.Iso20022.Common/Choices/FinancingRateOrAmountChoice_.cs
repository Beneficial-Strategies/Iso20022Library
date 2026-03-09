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
    /// Choice between amount expressed as an absolute value or as a percentage rate related to another reference amount.
    /// </summary>
    [KnownType(typeof(FinancingRateOrAmountChoice.Amount))]
    [KnownType(typeof(FinancingRateOrAmountChoice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancingRateOrAmountChoice.Amount),nameof(FinancingRateOrAmountChoice.Amount))]
    [JsonDerivedType(typeof(FinancingRateOrAmountChoice.Rate),nameof(FinancingRateOrAmountChoice.Rate))]
    #endif
    [IsoId("_RXzecNp-Ed-ak6NoX_4Aeg_-2069508751")]
    [DisplayName("Financing Rate Or Amount Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancingRateOrAmountChoice_
    #else
    public abstract partial class FinancingRateOrAmountChoice_
    #endif
    {
    }
}

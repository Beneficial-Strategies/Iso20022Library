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
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(CategoryPurpose1Choice.Code))]
    [KnownType(typeof(CategoryPurpose1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CategoryPurpose1Choice.Code),nameof(CategoryPurpose1Choice.Code))]
    [JsonDerivedType(typeof(CategoryPurpose1Choice.Proprietary),nameof(CategoryPurpose1Choice.Proprietary))]
    #endif
    [IsoId("_THaa5Np-Ed-ak6NoX_4Aeg_1223014142")]
    [DisplayName("Category Purpose 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CategoryPurpose1Choice_
    #else
    public abstract partial class CategoryPurpose1Choice_
    #endif
    {
    }
}

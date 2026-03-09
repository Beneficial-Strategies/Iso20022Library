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
    /// Choice between specification of the balance type in structured or free text format.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType1Choice.Structured))]
    [KnownType(typeof(SecuritiesBalanceType1Choice.Unstructured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesBalanceType1Choice.Structured),nameof(SecuritiesBalanceType1Choice.Structured))]
    [JsonDerivedType(typeof(SecuritiesBalanceType1Choice.Unstructured),nameof(SecuritiesBalanceType1Choice.Unstructured))]
    #endif
    [IsoId("_U11Ehdp-Ed-ak6NoX_4Aeg_-710964651")]
    [DisplayName("Securities Balance Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesBalanceType1Choice_
    #else
    public abstract partial class SecuritiesBalanceType1Choice_
    #endif
    {
    }
}

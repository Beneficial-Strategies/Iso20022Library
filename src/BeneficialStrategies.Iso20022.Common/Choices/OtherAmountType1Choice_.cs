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
    /// Choice between formats for a type of amount.
    /// </summary>
    [KnownType(typeof(OtherAmountType1Choice.Code))]
    [KnownType(typeof(OtherAmountType1Choice.ProprietaryCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OtherAmountType1Choice.Code),nameof(OtherAmountType1Choice.Code))]
    [JsonDerivedType(typeof(OtherAmountType1Choice.ProprietaryCode),nameof(OtherAmountType1Choice.ProprietaryCode))]
    #endif
    [IsoId("_WLNL4I2NEeeNN9vGwZc5aA")]
    [DisplayName("Other Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OtherAmountType1Choice_
    #else
    public abstract partial class OtherAmountType1Choice_
    #endif
    {
    }
}

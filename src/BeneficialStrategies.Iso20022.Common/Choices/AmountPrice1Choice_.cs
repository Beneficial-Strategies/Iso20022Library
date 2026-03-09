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
    /// Choice between ways to express an amount.
    /// </summary>
    [KnownType(typeof(AmountPrice1Choice.Amount))]
    [KnownType(typeof(AmountPrice1Choice.UnitPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountPrice1Choice.Amount),nameof(AmountPrice1Choice.Amount))]
    [JsonDerivedType(typeof(AmountPrice1Choice.UnitPrice),nameof(AmountPrice1Choice.UnitPrice))]
    #endif
    [IsoId("_VMB-CNp-Ed-ak6NoX_4Aeg_834424130")]
    [DisplayName("Amount Price 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountPrice1Choice_
    #else
    public abstract partial class AmountPrice1Choice_
    #endif
    {
    }
}

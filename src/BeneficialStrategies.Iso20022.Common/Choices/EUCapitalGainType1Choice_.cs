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
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType1Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUCapitalGainType1Choice.EUCapitalGain),nameof(EUCapitalGainType1Choice.EUCapitalGain))]
    [JsonDerivedType(typeof(EUCapitalGainType1Choice.Proprietary),nameof(EUCapitalGainType1Choice.Proprietary))]
    #endif
    [IsoId("_RgcdFdp-Ed-ak6NoX_4Aeg_-2050790406")]
    [DisplayName("EU Capital Gain Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGainType1Choice_
    #else
    public abstract partial class EUCapitalGainType1Choice_
    #endif
    {
    }
}

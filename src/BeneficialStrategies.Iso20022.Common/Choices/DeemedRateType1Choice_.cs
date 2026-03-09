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
    /// Choice between a standard code or proprietary code to specify a deemed rate type.
    /// </summary>
    [KnownType(typeof(DeemedRateType1Choice.Code))]
    [KnownType(typeof(DeemedRateType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeemedRateType1Choice.Code),nameof(DeemedRateType1Choice.Code))]
    [JsonDerivedType(typeof(DeemedRateType1Choice.Proprietary),nameof(DeemedRateType1Choice.Proprietary))]
    #endif
    [IsoId("_D-CdM5SmEeeh5JjedkaA_g")]
    [DisplayName("Deemed Rate Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeemedRateType1Choice_
    #else
    public abstract partial class DeemedRateType1Choice_
    #endif
    {
    }
}

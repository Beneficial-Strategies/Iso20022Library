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
    /// Choice of formats to express the type of taxes.
    /// </summary>
    [KnownType(typeof(TaxTypeFormat1Choice.Code))]
    [KnownType(typeof(TaxTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxTypeFormat1Choice.Code),nameof(TaxTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(TaxTypeFormat1Choice.Proprietary),nameof(TaxTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_SumZEgEcEeCQm6a_G2yO_w_1045052724")]
    [DisplayName("Tax Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxTypeFormat1Choice_
    #else
    public abstract partial class TaxTypeFormat1Choice_
    #endif
    {
    }
}

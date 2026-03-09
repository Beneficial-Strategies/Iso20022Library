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
    /// Specifies the technical input channel.
    /// </summary>
    [KnownType(typeof(TechnicalInputChannel1Choice.Code))]
    [KnownType(typeof(TechnicalInputChannel1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TechnicalInputChannel1Choice.Code),nameof(TechnicalInputChannel1Choice.Code))]
    [JsonDerivedType(typeof(TechnicalInputChannel1Choice.Proprietary),nameof(TechnicalInputChannel1Choice.Proprietary))]
    #endif
    [IsoId("_Rpr4odp-Ed-ak6NoX_4Aeg_-1373581543")]
    [DisplayName("Technical Input Channel 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TechnicalInputChannel1Choice_
    #else
    public abstract partial class TechnicalInputChannel1Choice_
    #endif
    {
    }
}

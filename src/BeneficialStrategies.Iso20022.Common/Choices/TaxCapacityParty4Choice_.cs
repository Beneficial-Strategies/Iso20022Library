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
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty4Choice.Code))]
    [KnownType(typeof(TaxCapacityParty4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxCapacityParty4Choice.Code),nameof(TaxCapacityParty4Choice.Code))]
    [JsonDerivedType(typeof(TaxCapacityParty4Choice.Proprietary),nameof(TaxCapacityParty4Choice.Proprietary))]
    #endif
    [IsoId("_PeuuwTqHEeWVrPy0StzzSg")]
    [DisplayName("Tax Capacity Party 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCapacityParty4Choice_
    #else
    public abstract partial class TaxCapacityParty4Choice_
    #endif
    {
    }
}

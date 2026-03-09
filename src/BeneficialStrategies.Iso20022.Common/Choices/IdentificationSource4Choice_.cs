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
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource4Choice.Code))]
    [KnownType(typeof(IdentificationSource4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IdentificationSource4Choice.Code),nameof(IdentificationSource4Choice.Code))]
    [JsonDerivedType(typeof(IdentificationSource4Choice.Proprietary),nameof(IdentificationSource4Choice.Proprietary))]
    #endif
    [IsoId("_uPmNYAgWEeCVlvYcV4HKqQ")]
    [DisplayName("Identification Source 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationSource4Choice_
    #else
    public abstract partial class IdentificationSource4Choice_
    #endif
    {
    }
}

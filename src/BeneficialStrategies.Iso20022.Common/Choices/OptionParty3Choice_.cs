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
    /// Choice of format for option party.
    /// </summary>
    [KnownType(typeof(OptionParty3Choice.Code))]
    [KnownType(typeof(OptionParty3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionParty3Choice.Code),nameof(OptionParty3Choice.Code))]
    [JsonDerivedType(typeof(OptionParty3Choice.Proprietary),nameof(OptionParty3Choice.Proprietary))]
    #endif
    [IsoId("_mzO2kWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Party 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionParty3Choice_
    #else
    public abstract partial class OptionParty3Choice_
    #endif
    {
    }
}

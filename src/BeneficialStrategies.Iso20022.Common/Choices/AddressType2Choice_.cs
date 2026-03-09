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
    /// Choice of formats for the type of address.
    /// </summary>
    [KnownType(typeof(AddressType2Choice.Code))]
    [KnownType(typeof(AddressType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AddressType2Choice.Code),nameof(AddressType2Choice.Code))]
    [JsonDerivedType(typeof(AddressType2Choice.Proprietary),nameof(AddressType2Choice.Proprietary))]
    #endif
    [IsoId("_DfORECFzEeW9XJWqfgXIIA")]
    [DisplayName("Address Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AddressType2Choice_
    #else
    public abstract partial class AddressType2Choice_
    #endif
    {
    }
}

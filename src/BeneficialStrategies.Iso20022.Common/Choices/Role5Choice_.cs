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
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role5Choice.Code))]
    [KnownType(typeof(Role5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Role5Choice.Code),nameof(Role5Choice.Code))]
    [JsonDerivedType(typeof(Role5Choice.Proprietary),nameof(Role5Choice.Proprietary))]
    #endif
    [IsoId("_VyKu4Z-zEeO1d8sv7xazyA")]
    [DisplayName("Role 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Role5Choice_
    #else
    public abstract partial class Role5Choice_
    #endif
    {
    }
}

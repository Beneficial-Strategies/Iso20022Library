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
    [KnownType(typeof(Role7Choice.Code))]
    [KnownType(typeof(Role7Choice.Proprietary))]
    [KnownType(typeof(Role7Choice.Text))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Role7Choice.Code),nameof(Role7Choice.Code))]
    [JsonDerivedType(typeof(Role7Choice.Proprietary),nameof(Role7Choice.Proprietary))]
    [JsonDerivedType(typeof(Role7Choice.Text),nameof(Role7Choice.Text))]
    #endif
    [IsoId("_5WyhAZNLEeWGlc8L7oPDIg")]
    [DisplayName("Role 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Role7Choice_
    #else
    public abstract partial class Role7Choice_
    #endif
    {
    }
}

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
    /// Prefix used for name.
    /// </summary>
    [KnownType(typeof(NamePrefix2Choice.NamePrefix))]
    [KnownType(typeof(NamePrefix2Choice.ExtendedNamePrefix))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NamePrefix2Choice.NamePrefix),nameof(NamePrefix2Choice.NamePrefix))]
    [JsonDerivedType(typeof(NamePrefix2Choice.ExtendedNamePrefix),nameof(NamePrefix2Choice.ExtendedNamePrefix))]
    #endif
    [IsoId("_HMqgQQ2fEeSNWNtJlXOAhg")]
    [DisplayName("Name Prefix 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NamePrefix2Choice_
    #else
    public abstract partial class NamePrefix2Choice_
    #endif
    {
    }
}

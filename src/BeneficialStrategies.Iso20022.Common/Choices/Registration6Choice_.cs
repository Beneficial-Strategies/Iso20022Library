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
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration6Choice.Code))]
    [KnownType(typeof(Registration6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Registration6Choice.Code),nameof(Registration6Choice.Code))]
    [JsonDerivedType(typeof(Registration6Choice.Proprietary),nameof(Registration6Choice.Proprietary))]
    #endif
    [IsoId("_AZjk9NokEeC60axPepSq7g_13891142")]
    [DisplayName("Registration 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Registration6Choice_
    #else
    public abstract partial class Registration6Choice_
    #endif
    {
    }
}

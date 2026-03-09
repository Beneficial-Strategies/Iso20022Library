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
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons6Choice.Code))]
    [KnownType(typeof(GeneratedReasons6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeneratedReasons6Choice.Code),nameof(GeneratedReasons6Choice.Code))]
    [JsonDerivedType(typeof(GeneratedReasons6Choice.Proprietary),nameof(GeneratedReasons6Choice.Proprietary))]
    #endif
    [IsoId("_6d7vVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Reasons 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneratedReasons6Choice_
    #else
    public abstract partial class GeneratedReasons6Choice_
    #endif
    {
    }
}

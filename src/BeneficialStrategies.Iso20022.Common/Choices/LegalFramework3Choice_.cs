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
    /// Choice of format for the legal framework.
    /// </summary>
    [KnownType(typeof(LegalFramework3Choice.Code))]
    [KnownType(typeof(LegalFramework3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LegalFramework3Choice.Code),nameof(LegalFramework3Choice.Code))]
    [JsonDerivedType(typeof(LegalFramework3Choice.Proprietary),nameof(LegalFramework3Choice.Proprietary))]
    #endif
    [IsoId("_-5gGQTqkEeWyoP0PbocV1Q")]
    [DisplayName("Legal Framework 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LegalFramework3Choice_
    #else
    public abstract partial class LegalFramework3Choice_
    #endif
    {
    }
}

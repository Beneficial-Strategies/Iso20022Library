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
    /// Choice of format for the replacement processing status.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus9Choice.Code))]
    [KnownType(typeof(ReplacementProcessingStatus9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReplacementProcessingStatus9Choice.Code),nameof(ReplacementProcessingStatus9Choice.Code))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus9Choice.Proprietary),nameof(ReplacementProcessingStatus9Choice.Proprietary))]
    #endif
    [IsoId("_8QcPaZNLEeWGlc8L7oPDIg")]
    [DisplayName("Replacement Processing Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReplacementProcessingStatus9Choice_
    #else
    public abstract partial class ReplacementProcessingStatus9Choice_
    #endif
    {
    }
}

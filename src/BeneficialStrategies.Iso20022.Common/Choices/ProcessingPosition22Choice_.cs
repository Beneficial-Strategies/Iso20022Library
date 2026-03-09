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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition22Choice.Code))]
    [KnownType(typeof(ProcessingPosition22Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingPosition22Choice.Code),nameof(ProcessingPosition22Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition22Choice.Proprietary),nameof(ProcessingPosition22Choice.Proprietary))]
    #endif
    [IsoId("_Vye1o5qLEeWcAIE4lEkF_Q")]
    [DisplayName("Processing Position 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition22Choice_
    #else
    public abstract partial class ProcessingPosition22Choice_
    #endif
    {
    }
}

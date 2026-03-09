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
    [KnownType(typeof(ProcessingPosition10Choice.Code))]
    [KnownType(typeof(ProcessingPosition10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingPosition10Choice.Code),nameof(ProcessingPosition10Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition10Choice.Proprietary),nameof(ProcessingPosition10Choice.Proprietary))]
    #endif
    [IsoId("_chT0q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Processing Position 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition10Choice_
    #else
    public abstract partial class ProcessingPosition10Choice_
    #endif
    {
    }
}

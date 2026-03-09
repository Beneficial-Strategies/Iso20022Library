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
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType22Choice.Addition))]
    [KnownType(typeof(UpdateType22Choice.Deletion))]
    [KnownType(typeof(UpdateType22Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType22Choice.Addition),nameof(UpdateType22Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType22Choice.Deletion),nameof(UpdateType22Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType22Choice.Modification),nameof(UpdateType22Choice.Modification))]
    #endif
    [IsoId("_61RRNZNLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType22Choice_
    #else
    public abstract partial class UpdateType22Choice_
    #endif
    {
    }
}

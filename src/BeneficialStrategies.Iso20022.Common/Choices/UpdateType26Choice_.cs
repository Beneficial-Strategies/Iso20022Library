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
    [KnownType(typeof(UpdateType26Choice.Addition))]
    [KnownType(typeof(UpdateType26Choice.Deletion))]
    [KnownType(typeof(UpdateType26Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType26Choice.Addition),nameof(UpdateType26Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType26Choice.Deletion),nameof(UpdateType26Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType26Choice.Modification),nameof(UpdateType26Choice.Modification))]
    #endif
    [IsoId("_JfG62Zw3EeazcsnODTksnQ")]
    [DisplayName("Update Type 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType26Choice_
    #else
    public abstract partial class UpdateType26Choice_
    #endif
    {
    }
}

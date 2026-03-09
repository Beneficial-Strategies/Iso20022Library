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
    [KnownType(typeof(UpdateType9Choice.Addition))]
    [KnownType(typeof(UpdateType9Choice.Deletion))]
    [KnownType(typeof(UpdateType9Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType9Choice.Addition),nameof(UpdateType9Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType9Choice.Deletion),nameof(UpdateType9Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType9Choice.Modification),nameof(UpdateType9Choice.Modification))]
    #endif
    [IsoId("_nBXQ4Q0BEeKd14R19frrfQ")]
    [DisplayName("Update Type 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType9Choice_
    #else
    public abstract partial class UpdateType9Choice_
    #endif
    {
    }
}

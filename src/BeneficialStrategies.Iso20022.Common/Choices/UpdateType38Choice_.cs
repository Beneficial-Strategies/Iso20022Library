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
    [KnownType(typeof(UpdateType38Choice.Addition))]
    [KnownType(typeof(UpdateType38Choice.Deletion))]
    [KnownType(typeof(UpdateType38Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType38Choice.Addition),nameof(UpdateType38Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType38Choice.Deletion),nameof(UpdateType38Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType38Choice.Modification),nameof(UpdateType38Choice.Modification))]
    #endif
    [IsoId("_eZThlTi8Eeydid5dcNPKvg")]
    [DisplayName("Update Type 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType38Choice_
    #else
    public abstract partial class UpdateType38Choice_
    #endif
    {
    }
}

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
    [KnownType(typeof(UpdateType30Choice.Addition))]
    [KnownType(typeof(UpdateType30Choice.Deletion))]
    [KnownType(typeof(UpdateType30Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType30Choice.Addition),nameof(UpdateType30Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType30Choice.Deletion),nameof(UpdateType30Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType30Choice.Modification),nameof(UpdateType30Choice.Modification))]
    #endif
    [IsoId("_fpPMoffYEeiNZp_PtLohLw")]
    [DisplayName("Update Type 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType30Choice_
    #else
    public abstract partial class UpdateType30Choice_
    #endif
    {
    }
}

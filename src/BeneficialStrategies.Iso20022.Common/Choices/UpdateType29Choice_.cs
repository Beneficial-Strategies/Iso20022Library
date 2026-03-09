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
    [KnownType(typeof(UpdateType29Choice.Addition))]
    [KnownType(typeof(UpdateType29Choice.Deletion))]
    [KnownType(typeof(UpdateType29Choice.Modification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType29Choice.Addition),nameof(UpdateType29Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType29Choice.Deletion),nameof(UpdateType29Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType29Choice.Modification),nameof(UpdateType29Choice.Modification))]
    #endif
    [IsoId("_ubeXIcvGEeihG9bKfarOOA")]
    [DisplayName("Update Type 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType29Choice_
    #else
    public abstract partial class UpdateType29Choice_
    #endif
    {
    }
}

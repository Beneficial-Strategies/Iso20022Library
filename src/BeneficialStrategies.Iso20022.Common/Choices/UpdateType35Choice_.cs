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
    /// Choice between action to request on a security.
    /// </summary>
    [KnownType(typeof(UpdateType35Choice.Add))]
    [KnownType(typeof(UpdateType35Choice.Delete))]
    [KnownType(typeof(UpdateType35Choice.Modify))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UpdateType35Choice.Add),nameof(UpdateType35Choice.Add))]
    [JsonDerivedType(typeof(UpdateType35Choice.Delete),nameof(UpdateType35Choice.Delete))]
    [JsonDerivedType(typeof(UpdateType35Choice.Modify),nameof(UpdateType35Choice.Modify))]
    #endif
    [IsoId("_QMJpmZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType35Choice_
    #else
    public abstract partial class UpdateType35Choice_
    #endif
    {
    }
}

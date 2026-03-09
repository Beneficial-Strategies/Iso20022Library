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
    /// Choice between formats for the entity to which the financial instruments are pledged.
    /// </summary>
    [KnownType(typeof(PledgeeFormat6Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat6Choice.Identification))]
    [KnownType(typeof(PledgeeFormat6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PledgeeFormat6Choice.TypeAndIdentification),nameof(PledgeeFormat6Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat6Choice.Identification),nameof(PledgeeFormat6Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat6Choice.Proprietary),nameof(PledgeeFormat6Choice.Proprietary))]
    #endif
    [IsoId("_Z07smffVEeiNZp_PtLohLw")]
    [DisplayName("Pledgee Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat6Choice_
    #else
    public abstract partial class PledgeeFormat6Choice_
    #endif
    {
    }
}

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
    [KnownType(typeof(PledgeeFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat3Choice.Identification))]
    [KnownType(typeof(PledgeeFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PledgeeFormat3Choice.TypeAndIdentification),nameof(PledgeeFormat3Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat3Choice.Identification),nameof(PledgeeFormat3Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat3Choice.Proprietary),nameof(PledgeeFormat3Choice.Proprietary))]
    #endif
    [IsoId("_8tov4TnZEeWV5sr121Fc8A")]
    [DisplayName("Pledgee Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat3Choice_
    #else
    public abstract partial class PledgeeFormat3Choice_
    #endif
    {
    }
}

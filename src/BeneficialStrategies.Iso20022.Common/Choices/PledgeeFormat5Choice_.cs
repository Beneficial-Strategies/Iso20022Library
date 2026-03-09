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
    [KnownType(typeof(PledgeeFormat5Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat5Choice.Identification))]
    [KnownType(typeof(PledgeeFormat5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PledgeeFormat5Choice.TypeAndIdentification),nameof(PledgeeFormat5Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat5Choice.Identification),nameof(PledgeeFormat5Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat5Choice.Proprietary),nameof(PledgeeFormat5Choice.Proprietary))]
    #endif
    [IsoId("_YdRwN9LGEeiN28wlpBQScw")]
    [DisplayName("Pledgee Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat5Choice_
    #else
    public abstract partial class PledgeeFormat5Choice_
    #endif
    {
    }
}

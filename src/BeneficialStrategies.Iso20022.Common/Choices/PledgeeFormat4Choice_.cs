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
    [KnownType(typeof(PledgeeFormat4Choice.TypeAndIdentification))]
    [KnownType(typeof(PledgeeFormat4Choice.Identification))]
    [KnownType(typeof(PledgeeFormat4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PledgeeFormat4Choice.TypeAndIdentification),nameof(PledgeeFormat4Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(PledgeeFormat4Choice.Identification),nameof(PledgeeFormat4Choice.Identification))]
    [JsonDerivedType(typeof(PledgeeFormat4Choice.Proprietary),nameof(PledgeeFormat4Choice.Proprietary))]
    #endif
    [IsoId("_W1AgMZj3EeWn2ur3BXxtdg")]
    [DisplayName("Pledgee Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PledgeeFormat4Choice_
    #else
    public abstract partial class PledgeeFormat4Choice_
    #endif
    {
    }
}

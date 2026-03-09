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
    /// Choice of formats for the specification of the role.
    /// </summary>
    [KnownType(typeof(PartyRole4Choice.Code))]
    [KnownType(typeof(PartyRole4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyRole4Choice.Code),nameof(PartyRole4Choice.Code))]
    [JsonDerivedType(typeof(PartyRole4Choice.Proprietary),nameof(PartyRole4Choice.Proprietary))]
    #endif
    [IsoId("_XXtRYV92EeS7xuKaq75oiQ")]
    [DisplayName("Party Role 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyRole4Choice_
    #else
    public abstract partial class PartyRole4Choice_
    #endif
    {
    }
}

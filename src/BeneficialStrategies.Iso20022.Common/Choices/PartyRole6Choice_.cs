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
    /// Choice between a code and or a data source scheme to determine the role of the party.
    /// </summary>
    [KnownType(typeof(PartyRole6Choice.Code))]
    [KnownType(typeof(PartyRole6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyRole6Choice.Code),nameof(PartyRole6Choice.Code))]
    [JsonDerivedType(typeof(PartyRole6Choice.Proprietary),nameof(PartyRole6Choice.Proprietary))]
    #endif
    [IsoId("_Ny0Ls46OEemzmeK8_tPygg")]
    [DisplayName("Party Role 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyRole6Choice_
    #else
    public abstract partial class PartyRole6Choice_
    #endif
    {
    }
}

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
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party15Choice.Organisation))]
    [KnownType(typeof(Party15Choice.IndividualPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party15Choice.Organisation),nameof(Party15Choice.Organisation))]
    [JsonDerivedType(typeof(Party15Choice.IndividualPerson),nameof(Party15Choice.IndividualPerson))]
    #endif
    [IsoId("_Wf_qkRRQEeOKWo1NF21OVw")]
    [DisplayName("Party 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party15Choice_
    #else
    public abstract partial class Party15Choice_
    #endif
    {
    }
}

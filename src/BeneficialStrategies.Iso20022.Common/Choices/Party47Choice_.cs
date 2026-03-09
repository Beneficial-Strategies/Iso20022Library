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
    [KnownType(typeof(Party47Choice.Organisation))]
    [KnownType(typeof(Party47Choice.IndividualPerson))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Party47Choice.Organisation),nameof(Party47Choice.Organisation))]
    [JsonDerivedType(typeof(Party47Choice.IndividualPerson),nameof(Party47Choice.IndividualPerson))]
    #endif
    [IsoId("_lvVOY5Q_EemqYPWMBuVawg")]
    [DisplayName("Party 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Party47Choice_
    #else
    public abstract partial class Party47Choice_
    #endif
    {
    }
}

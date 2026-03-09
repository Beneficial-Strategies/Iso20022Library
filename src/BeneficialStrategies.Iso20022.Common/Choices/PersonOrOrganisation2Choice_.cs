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
    /// Specifies the identification of a person or an organisation.
    /// </summary>
    [KnownType(typeof(PersonOrOrganisation2Choice.LEI))]
    [KnownType(typeof(PersonOrOrganisation2Choice.Person))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PersonOrOrganisation2Choice.LEI),nameof(PersonOrOrganisation2Choice.LEI))]
    [JsonDerivedType(typeof(PersonOrOrganisation2Choice.Person),nameof(PersonOrOrganisation2Choice.Person))]
    #endif
    [IsoId("_9-fNkQkiEeWGouz230Xp5Q")]
    [DisplayName("Person Or Organisation 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PersonOrOrganisation2Choice_
    #else
    public abstract partial class PersonOrOrganisation2Choice_
    #endif
    {
    }
}

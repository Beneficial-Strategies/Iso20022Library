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
    /// Choice of formats for the identification of an individual person.
    /// </summary>
    [KnownType(typeof(IndividualPersonIdentification2Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification2Choice.PersonName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndividualPersonIdentification2Choice.IdentificationNumber),nameof(IndividualPersonIdentification2Choice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentification2Choice.PersonName),nameof(IndividualPersonIdentification2Choice.PersonName))]
    #endif
    [IsoId("_5uE1YSGZEeWKAaDJcYGKLw")]
    [DisplayName("Individual Person Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndividualPersonIdentification2Choice_
    #else
    public abstract partial class IndividualPersonIdentification2Choice_
    #endif
    {
    }
}

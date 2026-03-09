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
    [KnownType(typeof(IndividualPersonIdentification3Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification3Choice.PersonName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndividualPersonIdentification3Choice.IdentificationNumber),nameof(IndividualPersonIdentification3Choice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentification3Choice.PersonName),nameof(IndividualPersonIdentification3Choice.PersonName))]
    #endif
    [IsoId("_GWjI8YoWEeahcZ3Nzs1Qag")]
    [DisplayName("Individual Person Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndividualPersonIdentification3Choice_
    #else
    public abstract partial class IndividualPersonIdentification3Choice_
    #endif
    {
    }
}

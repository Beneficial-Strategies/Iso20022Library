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
    [KnownType(typeof(IndividualPersonIdentification1Choice.IdentificationNumber))]
    [KnownType(typeof(IndividualPersonIdentification1Choice.PersonName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndividualPersonIdentification1Choice.IdentificationNumber),nameof(IndividualPersonIdentification1Choice.IdentificationNumber))]
    [JsonDerivedType(typeof(IndividualPersonIdentification1Choice.PersonName),nameof(IndividualPersonIdentification1Choice.PersonName))]
    #endif
    [IsoId("_gbR24SFWEeWgV9SQSyaAog")]
    [DisplayName("Individual Person Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndividualPersonIdentification1Choice_
    #else
    public abstract partial class IndividualPersonIdentification1Choice_
    #endif
    {
    }
}

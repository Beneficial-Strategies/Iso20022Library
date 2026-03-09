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
    [KnownType(typeof(PersonOrOrganisation1Choice.LEI))]
    [KnownType(typeof(PersonOrOrganisation1Choice.MIC))]
    [KnownType(typeof(PersonOrOrganisation1Choice.Person))]
    [KnownType(typeof(PersonOrOrganisation1Choice.Internal))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PersonOrOrganisation1Choice.LEI),nameof(PersonOrOrganisation1Choice.LEI))]
    [JsonDerivedType(typeof(PersonOrOrganisation1Choice.MIC),nameof(PersonOrOrganisation1Choice.MIC))]
    [JsonDerivedType(typeof(PersonOrOrganisation1Choice.Person),nameof(PersonOrOrganisation1Choice.Person))]
    [JsonDerivedType(typeof(PersonOrOrganisation1Choice.Internal),nameof(PersonOrOrganisation1Choice.Internal))]
    #endif
    [IsoId("_va6b4PPYEeS_qLctCs2aRQ")]
    [DisplayName("Person Or Organisation 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PersonOrOrganisation1Choice_
    #else
    public abstract partial class PersonOrOrganisation1Choice_
    #endif
    {
    }
}

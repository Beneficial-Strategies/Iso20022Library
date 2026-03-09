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
    /// Choice between an organisation and an individual person.
    /// </summary>
    [KnownType(typeof(AccountOwner1Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(AccountOwner1Choice.OrganisationOwnerIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountOwner1Choice.IndividualOwnerIdentification),nameof(AccountOwner1Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(AccountOwner1Choice.OrganisationOwnerIdentification),nameof(AccountOwner1Choice.OrganisationOwnerIdentification))]
    #endif
    [IsoId("_Mo3jsCFTEeWgV9SQSyaAog")]
    [DisplayName("Account Owner 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountOwner1Choice_
    #else
    public abstract partial class AccountOwner1Choice_
    #endif
    {
    }
}

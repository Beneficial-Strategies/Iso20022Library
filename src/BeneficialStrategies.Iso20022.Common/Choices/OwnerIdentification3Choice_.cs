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
    /// Choice of individual or organisation details.
    /// </summary>
    [KnownType(typeof(OwnerIdentification3Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(OwnerIdentification3Choice.OrganisationOwnerIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OwnerIdentification3Choice.IndividualOwnerIdentification),nameof(OwnerIdentification3Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification3Choice.OrganisationOwnerIdentification),nameof(OwnerIdentification3Choice.OrganisationOwnerIdentification))]
    #endif
    [IsoId("_B1IjUZTREemC09f0MxYkRg")]
    [DisplayName("Owner Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OwnerIdentification3Choice_
    #else
    public abstract partial class OwnerIdentification3Choice_
    #endif
    {
    }
}

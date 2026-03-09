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
    [KnownType(typeof(OwnerIdentification2Choice.IndividualOwnerIdentification))]
    [KnownType(typeof(OwnerIdentification2Choice.OrganisationOwnerIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OwnerIdentification2Choice.IndividualOwnerIdentification),nameof(OwnerIdentification2Choice.IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(OwnerIdentification2Choice.OrganisationOwnerIdentification),nameof(OwnerIdentification2Choice.OrganisationOwnerIdentification))]
    #endif
    [IsoId("_Es6-ASGZEeWKAaDJcYGKLw")]
    [DisplayName("Owner Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OwnerIdentification2Choice_
    #else
    public abstract partial class OwnerIdentification2Choice_
    #endif
    {
    }
}

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
    /// Provides the identification of the organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification9Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification9Choice.ClientIdentification))]
    [KnownType(typeof(OrganisationIdentification9Choice.AnyBIC))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrganisationIdentification9Choice.LEI),nameof(OrganisationIdentification9Choice.LEI))]
    [JsonDerivedType(typeof(OrganisationIdentification9Choice.ClientIdentification),nameof(OrganisationIdentification9Choice.ClientIdentification))]
    [JsonDerivedType(typeof(OrganisationIdentification9Choice.AnyBIC),nameof(OrganisationIdentification9Choice.AnyBIC))]
    #endif
    [IsoId("_L_GVAZQMEeiILOjNP8ro1w")]
    [DisplayName("Organisation Identification 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrganisationIdentification9Choice_
    #else
    public abstract partial class OrganisationIdentification9Choice_
    #endif
    {
    }
}

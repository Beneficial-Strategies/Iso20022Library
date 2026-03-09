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
    [KnownType(typeof(OrganisationIdentification10Choice.LEI))]
    [KnownType(typeof(OrganisationIdentification10Choice.Other))]
    [KnownType(typeof(OrganisationIdentification10Choice.AnyBIC))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.LEI),nameof(OrganisationIdentification10Choice.LEI))]
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.Other),nameof(OrganisationIdentification10Choice.Other))]
    [JsonDerivedType(typeof(OrganisationIdentification10Choice.AnyBIC),nameof(OrganisationIdentification10Choice.AnyBIC))]
    #endif
    [IsoId("_H2dUKe9IEemVGdgB8P8uQQ")]
    [DisplayName("Organisation Identification 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrganisationIdentification10Choice_
    #else
    public abstract partial class OrganisationIdentification10Choice_
    #endif
    {
    }
}

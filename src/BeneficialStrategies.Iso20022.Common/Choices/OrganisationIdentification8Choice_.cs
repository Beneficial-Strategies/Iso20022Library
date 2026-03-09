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
    /// Provides the identification of an organisation.
    /// </summary>
    [KnownType(typeof(OrganisationIdentification8Choice.ClientIdentification))]
    [KnownType(typeof(OrganisationIdentification8Choice.AnyBIC))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrganisationIdentification8Choice.ClientIdentification),nameof(OrganisationIdentification8Choice.ClientIdentification))]
    [JsonDerivedType(typeof(OrganisationIdentification8Choice.AnyBIC),nameof(OrganisationIdentification8Choice.AnyBIC))]
    #endif
    [IsoId("_8vgCgZQEEeiILOjNP8ro1w")]
    [DisplayName("Organisation Identification 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrganisationIdentification8Choice_
    #else
    public abstract partial class OrganisationIdentification8Choice_
    #endif
    {
    }
}
